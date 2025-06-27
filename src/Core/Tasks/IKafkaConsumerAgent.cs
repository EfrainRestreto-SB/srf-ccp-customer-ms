
namespace Core.Tasks
{
    internal interface IKafkaConsumerAgent<T1, T2>
    {
        void ConsumeMessages(ushort number, Func<string, global::Domain.Interfaces.Repositories.CustomerOutDto, Task> notifyToClient, CancellationToken cancellationToken);
    }
}