using Confluent.Kafka;
using Core.Interfaces.Configuration;
using Domain.Dto.In;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace Persistence.Agents
{
    public class KafkaCustomerProducerAgent
    {
        private readonly ILogger<KafkaCustomerProducerAgent> _logger;
        private readonly IProducer<Null, string> _producer;
        private readonly string _topic;

        public KafkaCustomerProducerAgent(
            ILogger<KafkaCustomerProducerAgent> logger,
            IOptions<IKafkaProducerConfig> kafkaConfig)
        {
            _logger = logger;
            var config = new ProducerConfig
            {
                BootstrapServers = kafkaConfig.Value.BootstrapServers
            };
            _producer = new ProducerBuilder<Null, string>(config).Build();
            _topic = kafkaConfig.Value.CustomerTopic;
        }

        public async Task SendMessageAsync(CustomerCreateInDto message)
        {
            var jsonMessage = JsonSerializer.Serialize(message);

            try
            {
                var deliveryResult = await _producer.ProduceAsync(_topic, new Message<Null, string> { Value = jsonMessage });
                _logger.LogInformation("Kafka message sent to topic {Topic}: {Message}", _topic, jsonMessage);
            }
            catch (ProduceException<Null, string> ex)
            {
                _logger.LogError(ex, "Error sending Kafka message: {Message}", jsonMessage);
                throw;
            }
        }
    }
}
