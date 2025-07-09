using Confluent.Kafka;
using Core.Interfaces.Configuration;
using Domain.Dto.In;
using Domain.Dtos.Customer.In;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace Persistence.Agents.AwsKafka
{
    public class KafkaCustomerConsumerAgent : BackgroundService
    {
        private readonly ILogger<KafkaCustomerConsumerAgent> _logger;
        private readonly IServiceProvider _serviceProvider;
        private readonly IKafkaConsumerConfig _config;

        public KafkaCustomerConsumerAgent(
            ILogger<KafkaCustomerConsumerAgent> logger,
            IOptions<IKafkaConsumerConfig> config,
            IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
            _config = config.Value;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var consumerConfig = new ConsumerConfig
            {
                BootstrapServers = _config.BootstrapServers,
                GroupId = _config.GroupId,
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<Ignore, string>((IEnumerable<KeyValuePair<string, string>>)consumerConfig).Build();
            consumer.Subscribe(_config.CustomerTopic);

            _logger.LogInformation("Kafka Customer Consumer started.");

            try
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    var result = consumer.Consume(stoppingToken);
                    _logger.LogInformation("Received message: {Message}", result.Message.Value);

                    var customerDto = JsonSerializer.Deserialize<CustomerCreateInDto>(result.Message.Value);

                    using (var scope = _serviceProvider.CreateScope())
                    {
                        var customerService = scope.ServiceProvider.GetRequiredService<ICustomerService>();
                        object value = await customerService.CreateCustomerAsync(customerDto!);
                    }
                }
            }
            catch (OperationCanceledException)
            {
                _logger.LogInformation("Kafka consumer stopped.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing Kafka message.");
            }
            finally
            {
                consumer.Close();
            }
        }
    }

    internal interface ICustomerService
    {
        Task<object> CreateCustomerAsync(CustomerCreateInDto customerCreateInDto);
    }
}
