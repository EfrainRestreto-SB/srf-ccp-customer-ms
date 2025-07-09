namespace Core.Config.AwsKafka
{
    public class KafkaConsumerCustomerCdtEvtConfig
    {
        public const string SectionName = "Kafka:CustomerCdtConsumer";

        public required string BootstrapServers { get; set; }
        public required string GroupId { get; set; }
        public required string Topic { get; set; }
        public bool EnableAutoCommit { get; set; } = true;
        public string AutoOffsetReset { get; set; } = "latest"; // "earliest" o "latest"
    }
}
