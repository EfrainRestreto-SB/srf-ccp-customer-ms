namespace Core.Config.SettingFile.AwsKafka
{
    public class KafkaCreateCustomerCmdJson
    {
        public const string SectionName = "Kafka:CustomerCreateProducer";

        /// <summary>
        /// Lista de brokers Kafka, e.g. "localhost:9092"
        /// </summary>
        public required string BootstrapServers { get; set; }

        /// <summary>
        /// Topic donde se producen los comandos de creación de cliente
        /// </summary>
        public required string Topic { get; set; }

        /// <summary>
        /// Acks: -1 (all), 0 (none) o 1 (leader)
        /// </summary>
        public int Acks { get; set; } = 1;
    }
}
