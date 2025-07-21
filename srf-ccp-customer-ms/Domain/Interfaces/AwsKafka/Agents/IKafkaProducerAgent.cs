namespace Domain.Interfaces.AwsKafka.Agents;

public interface IKafkaProducerAgent<in TKey, in TValue>
{
    public Task ProduceMessage(TKey key, TValue body);
}
