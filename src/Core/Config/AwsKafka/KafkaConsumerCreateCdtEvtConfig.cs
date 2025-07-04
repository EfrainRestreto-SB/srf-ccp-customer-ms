using System.Text.Json;
using Confluent.Kafka;
using Domain.Models.Customer.In;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Persistence.Cache.Interfaces;
using Persistence.Messaging.Agents;

namespace Persistence.Messaging.Kafka.Consumers;

public class KafkaConsumerCreateCustomer : BackgroundService
{
    private readonly IConfiguration _configuration;
    private readonly IRedisService _redisService;
    private readonly AS400MqAgent _mqAgent;
    private readonly ILogger<KafkaConsumerCreateCustomer> _logger;

    public KafkaConsumerCreateCustomer(
        IConfiguration configuration,
        IRedisService redisService,
        AS400MqAgent mqAgent,
        ILogger<KafkaConsumerCreateCustomer> logger)
    {
        _configuration = configuration;
        _redisService = redisService;
        _mqAgent = mqAgent;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = _configuration["Kafka:BootstrapServers"],
            GroupId = "customer-create-group",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using var consumer = new ConsumerBuilder<string, string>(config).Build();
        consumer.Subscribe("srf-ccp-clientes-cmd");

        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                var result = consumer.Consume(stoppingToken);
                var id = result.Message.Key;
                var payload = result.Message.Value;

                var customer = JsonSerializer.Deserialize<CustomerCreateInModel>(payload);

                if (customer != null)
                {
                    await _mqAgent.SendCustomerToAS400Async(id, customer);
                    _logger.LogInformation($"Cliente procesado y enviado a MQ: {id}");
                }
                else
                {
                    _logger.LogWarning($"Payload inválido para ID {id}");
                }
            }
            catch (ConsumeException ex)
            {
                _logger.LogError($"Kafka consume error: {ex.Error.Reason}");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error general en consumidor Kafka: {ex.Message}");
            }
        }
    }
}
