using Confluent.Kafka;

namespace Domain.Interfaces.AwsKafka.Config;

public interface IKafkaConsumerConfig
{
    public ConsumerConfig GetConsumerConfig();

    public string GetTopicName();
    
}