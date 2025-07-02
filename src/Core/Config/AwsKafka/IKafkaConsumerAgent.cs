using System;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Interfaces.AwsKafka.Agents;

public interface IKafkaConsumerAgent<TKey, TValue>
{
    Task ConsumeMessages(ushort consumerNumber, Func<TKey, TValue, Task> method, CancellationToken cancellationToken);
}
