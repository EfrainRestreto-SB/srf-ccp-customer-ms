namespace Core.Interfaces.Configuration
{
    public interface IKafkaProducerConfig
    {
        /// <summary>
        /// Dirección de los brokers Kafka. Ejemplo: "localhost:9092"
        /// </summary>
        string BootstrapServers { get; }

        /// <summary>
        /// Identificador del cliente productor
        /// </summary>
        string ClientId { get; }

        /// <summary>
        /// Configuración de confirmación de escritura. Ejemplo: "all", "1", "0"
        /// </summary>
        string Acks { get; }

        /// <summary>
        /// Tiempo máximo para que el broker responda a una solicitud (en milisegundos)
        /// </summary>
        int RequestTimeoutMs { get; }

        /// <summary>
        /// Tiempo máximo de espera para completar el envío del mensaje (en milisegundos)
        /// </summary>
        int MessageTimeoutMs { get; }

        /// <summary>
        /// Tamaño máximo permitido para los mensajes (en bytes)
        /// </summary>
        int MaxRequestSize { get; }
        string? CustomerTopic { get; set; }
    }
}
