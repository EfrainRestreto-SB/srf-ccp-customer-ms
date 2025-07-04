using System.Text.Json;
using Confluent.Kafka;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace Persistence.Agents.AwsKafka
{
    public class KafkaCustomerProducerAgent
    {
        private readonly ILogger<KafkaCustomerProducerAgent> _logger;
        private readonly IConfiguration _configuration;
        private readonly IProducer<string, string> _producer;

        public KafkaCustomerProducerAgent(ILogger<KafkaCustomerProducerAgent> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;

            var config = new ProducerConfig
            {
                BootstrapServers = _configuration["Kafka:BootstrapServers"],
                SecurityProtocol = SecurityProtocol.SaslSsl,
                SaslMechanism = SaslMechanism.Plain,
                SaslUsername = _configuration["Kafka:Username"],
                SaslPassword = _configuration["Kafka:Password"],
                Acks = Acks.All
            };

            _producer = new ProducerBuilder<string, string>(config).Build();
        }

        public async Task SendAsync<T>(string topic, T message)
        {
            var json = JsonSerializer.Serialize(message);
            var kafkaMessage = new Message<string, string>
            {
                Key = Guid.NewGuid().ToString(),
                Value = json
            };

            try
            {
                var result = await _producer.ProduceAsync(topic, kafkaMessage);
                _logger.LogInformation("Mensaje enviado correctamente al tópico {Topic}, offset: {Offset}", topic, result.Offset);
            }
            catch (ProduceException<string, string> ex)
            {
                _logger.LogError(ex, "Error al enviar mensaje a Kafka: {Reason}", ex.Error.Reason);
                throw;
            }
        }
    }
}
