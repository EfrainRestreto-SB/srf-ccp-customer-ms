namespace Core.Config.SettingFile.AwsKafka
{
    public class KafkaCreateCustomerEvtJson
    {
        /// <summary>
        /// Ruta de sección en appsettings.json
        /// </summary>
        public const string SectionName = "Kafka:CustomerCreateConsumer";

        /// <summary>
        /// Lista de brokers Kafka, e.g. "localhost:9092"
        /// </summary>
        public required string BootstrapServers { get; set; }

        /// <summary>
        /// Grupo de consumidor (GroupId)
        /// </summary>
        public required string GroupId { get; set; }

        /// <summary>
        /// Topic de eventos de creación de cliente
        /// </summary>
        public required string Topic { get; set; }

        /// <summary>
        /// AutoCommit: true para confirmación automática
        /// </summary>
        public bool EnableAutoCommit { get; set; } = true;

        /// <summary>
        /// AutoOffsetReset: "earliest" o "latest"
        /// </summary>
        public string AutoOffsetReset { get; set; } = "latest";
    }
}
