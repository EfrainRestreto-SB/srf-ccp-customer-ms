namespace Domain.Interfaces.AwsKafka.Config;

public interface IKafkaProducerConfig
{
    public ProducerConfig GetProducerConfig();

    public string GetTopicName();

    public int MaxRetries();
}