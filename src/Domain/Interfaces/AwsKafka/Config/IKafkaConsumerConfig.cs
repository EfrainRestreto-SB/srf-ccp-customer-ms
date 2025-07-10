
namespace Core.Interfaces.Configuration
{
    public interface IKafkaConsumerConfig
    {
        string BootstrapServers { get; }
        string GroupId { get; }
        string Topic { get; }
        bool EnableAutoCommit { get; } 
        IEnumerable<string> CustomerTopic { get; set; }
    }
}
