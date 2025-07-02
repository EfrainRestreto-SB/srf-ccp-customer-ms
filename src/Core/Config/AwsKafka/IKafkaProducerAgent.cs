using System.Threading.Tasks;

namespace Domain.Interfaces.AwsKafka.Agents;

public interface IKafkaProducerAgent<TKey, TValue>
{
    Task ProduceAsync(TKey key, TValue value);
}
