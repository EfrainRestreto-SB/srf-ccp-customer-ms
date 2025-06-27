namespace Domain.Interfaces.AwsKafka.Agents;

public interface IKafkaConsumerAgent<TKey, TValue>
{
    public Task ConsumeMessages(ushort consumerNumber, Func<TKey, TValue, Task> method, CancellationToken cancellationToken);
}
