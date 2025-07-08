
namespace Core.Interfaces.Configuration
{
    public interface IKafkaConsumerConfig
    {
        string BootstrapServers { get; }
        string GroupId { get; }
        string Topic { get; }
        bool EnableAutoCommit { get; } // Fixed CS0525, CS1002, CS1513  
        IEnumerable<string> CustomerTopic { get; set; }
    }
}
