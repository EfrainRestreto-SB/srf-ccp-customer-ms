using Domain.Interfaces.AwsKafka.Config;
using Persistence.Serializers;

namespace Persistence.Agents.AwsKafka
{
    internal class ConsumerBuilder<TKey, TValue>
    {
        private ConsumerConfig consumerConfig;

        public ConsumerBuilder(ConsumerConfig consumerConfig)
        {
            this.consumerConfig = consumerConfig;
        }

        internal object SetValueDeserializer<TValue>(JsonKafkaDeserializer<TValue> jsonKafkaDeserializer)
        {
            throw new NotImplementedException();
        }
    }
}