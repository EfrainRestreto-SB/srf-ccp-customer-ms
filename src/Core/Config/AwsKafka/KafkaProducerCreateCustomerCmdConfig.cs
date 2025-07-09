namespace Core.Config.AwsKafka
{
    public class KafkaProducerCreateCustomerCmdConfig
    {
        public const string SectionName = "Kafka:CustomerCreateProducer";

        public required string BootstrapServers { get; set; }
        public required string Topic { get; set; }
        public int Acks { get; set; } = 1; // 0, 1, -1 (all)
    }
}
