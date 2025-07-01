using Confluent.Kafka;
using Core.Config.SettingFiles.AwsKafka;
using Domain.Interfaces.AwsKafka.Config;
using Microsoft.Extensions.Options;

namespace Core.Config.AwsKafka;

public class KafkaProducerCreateCdtCmdConfig(IOptions<KafkaCreateCdtCmdJson> options) : IKafkaProducerConfig
{
    private readonly KafkaCreateCdtCmdJson config = options.Value;

    public ProducerConfig GetProducerConfig()
    {
        return new()
        {
            SaslMechanism = SaslMechanism.OAuthBearer,
            SecurityProtocol = SecurityProtocol.SaslSsl,
            BootstrapServers = config.BootstrapServers,
            MessageTimeoutMs = 150000,   // Aumentar el tiempo de espera de mensaje
            RequestTimeoutMs = 15000,   // Aumentar el tiempo de espera de solicitud
            RetryBackoffMs = 1000,      // Aumentar el tiempo de espera entre reintentos
            MaxInFlight = 5,            // Asegúrate de no tener demasiados mensajes en vuelo
            Acks = Acks.All,            // Asegúrate de esperar todos los acuses de recibo
            AllowAutoCreateTopics = true
        };
    }

    public string GetTopicName() => config.TopicName!;

    public int MaxRetries() => config.ProducerMaxRetries;
}