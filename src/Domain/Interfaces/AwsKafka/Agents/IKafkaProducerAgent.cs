using System.Threading.Tasks;

namespace Core.Interfaces.Agents
{
    public interface IKafkaProducerAgent<T>
    {
        Task SendMessageAsync(T message, string topic);
    }
}
