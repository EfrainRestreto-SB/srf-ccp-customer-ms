using System.Threading.Tasks;

namespace Core.Interfaces.Agents
{
    public interface IKafkaConsumerAgent<T>
    {
        Task ConsumeAsync(T message);
    }
}
