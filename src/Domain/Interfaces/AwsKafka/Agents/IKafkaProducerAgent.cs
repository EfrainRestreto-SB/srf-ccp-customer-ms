using System.Threading;
using System.Threading.Tasks;

namespace Domain.Interfaces.Agents;

public interface IKafkaConsumerAgent
{
    Task HandleMessageAsync(string key, string payload, CancellationToken cancellationToken);
}
