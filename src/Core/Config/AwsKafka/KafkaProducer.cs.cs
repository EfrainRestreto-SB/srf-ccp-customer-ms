using Confluent.Kafka;
using Newtonsoft.Json;

namespace SrfCcpCustomerMs.Core.Config.AwsKafka
{
    public class KafkaProducer
    {
        private readonly IProducer<Null, string> _producer;

        public KafkaProducer(IConfiguration configuration)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = configuration["Kafka:BootstrapServers"]
            };

            _producer = new ProducerBuilder<Null, string>(config).Build();
        }

        public async Task ProduceAsync(string topic, object message)
        {
            var json = JsonConvert.SerializeObject(message);
            await _producer.ProduceAsync(topic, new Message<Null, string> { Value = json });
        }
    }
}
