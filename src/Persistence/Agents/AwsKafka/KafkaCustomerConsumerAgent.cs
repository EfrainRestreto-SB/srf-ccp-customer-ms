using Application.Agents.Interfaces;
using Application.Services.Interfaces;
using Confluent.Kafka;
using Domain.Dtos.Customer.In;
using Domain.Interfaces.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Persistence.Agents.AwsKafka;

public class KafkaCustomerConsumerAgent : IKafkaCustomerConsumerAgent
{
    private readonly ILogger<KafkaCustomerConsumerAgent> _logger;
    private readonly IConfiguration _configuration;
    private readonly ICreateCustomerService _createCustomerService;

    public KafkaCustomerConsumerAgent(
        ILogger<KafkaCustomerConsumerAgent> logger,
        IConfiguration configuration,
        ICreateCustomerService createCustomerService)
    {
        _logger = logger;
        _configuration = configuration;
        _createCustomerService = createCustomerService;
    }

    public async Task ConsumeAsync(CancellationToken cancellationToken)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = _configuration["Kafka:BootstrapServers"],
            GroupId = _configuration["Kafka:CustomerConsumerGroup"],
            AutoOffsetReset = AutoOffsetReset.Earliest,
            EnableAutoCommit = false
        };

        using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
        var topic = _configuration["Kafka:CustomerTopic"];

        consumer.Subscribe(topic);

        _logger.LogInformation("KafkaCustomerConsumerAgent iniciado. Escuchando el tópico: {Topic}", topic);

        try
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    var result = consumer.Consume(cancellationToken);
                    var message = result.Message.Value;

                    _logger.LogInformation("Mensaje recibido: {Message}", message);

                    var dto = JsonSerializer.Deserialize<CustomerCreateInDto>(message);

                    if (dto is not null)
                    {
                        await _createCustomerService.CreateAsync(dto);
                        consumer.Commit(result);
                        _logger.LogInformation("Mensaje procesado y confirmado.");
                    }
                }
                catch (ConsumeException ex)
                {
                    _logger.LogError(ex, "Error al consumir mensaje de Kafka");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error inesperado procesando el mensaje del cliente");
                }
            }
        }
        finally
        {
            consumer.Close();
        }
    }
}
