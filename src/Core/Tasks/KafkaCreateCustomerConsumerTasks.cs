using Confluent.Kafka;
using System.Text.Json;
using Google.Api.Ads.AdWords.v201809;

namespace Infrastructure.Kafka.Consumers
{
    public class KafkaCreateCustomerConsumer : BackgroundService
    {
        private readonly ILogger<KafkaCreateCustomerConsumer> _logger;
        private readonly ICustomerService _customerService;
        private readonly IConsumer<Ignore, string> _consumer;

        private const string TopicName = "customer.create";

        public KafkaCreateCustomerConsumer(
            ILogger<KafkaCreateCustomerConsumer> logger,
            ICustomerService customerService,
            ConsumerConfig consumerConfig)
        {
            _logger = logger;
            _customerService = customerService;

            _consumer = new ConsumerBuilder<Ignore, string>(consumerConfig)
                .SetErrorHandler((_, e) => _logger.LogError("Kafka error: {Error}", e.Reason))
                .Build();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _consumer.Subscribe(TopicName);
            _logger.LogInformation("Kafka Consumer subscribed to topic: {Topic}", TopicName);

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    var consumeResult = _consumer.Consume(stoppingToken);

                    if (consumeResult != null && !string.IsNullOrEmpty(consumeResult.Message.Value))
                    {
                        var messageValue = consumeResult.Message.Value;
                        _logger.LogInformation("Kafka message received: {Message}", messageValue);

                        // Deserialize the Kafka message  
                        var customerDto = JsonSerializer.Deserialize<Domain.Dto.In.CustomerCreateInDto>(messageValue);
                        if (customerDto != null)
                        {
                        //    object value = await _customerService.CreateCustomerAsync(customerDto);
                            _logger.LogInformation("Customer created successfully.");
                        }
                        else
                        {
                            _logger.LogWarning("Failed to deserialize Kafka message.");
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    _logger.LogInformation("Kafka consumer operation canceled.");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error occurred while consuming Kafka message.");
                }
            }

            _consumer.Close();
        }
    }

}
