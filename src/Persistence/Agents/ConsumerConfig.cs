namespace Persistence.Agents
{
    internal class ConsumerConfig
    {
        public string BootstrapServers { get; set; }
        public string GroupId { get; set; }
        public object AutoOffsetReset { get; set; }
        public bool EnableAutoCommit { get; set; }
    }
}