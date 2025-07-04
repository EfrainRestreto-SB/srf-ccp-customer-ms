using Confluent.Kafka;
using Core.Config.SettingFiles.AwsKafka;
using Domain.Interfaces.AwsKafka.Config;
using Microsoft.Extensions.Options;

namespace Core.Config.AwsKafka;

public class KafkaProducerCreateCustomerCmdConfig(IOptions<KafkaCreateCustomerCmdJson> options) : IKafkaProducerConfig
{
    private readonly KafkaCreateCustomerCmdJson config = options.Value;

    public ProducerConfig GetProducerConfig()
    {
        return new()
        {
            SaslMechanism = SaslMechanism.OAuthBearer,
            SecurityProtocol = SecurityProtocol.SaslSsl,
            BootstrapServers = config.BootstrapServers,
            MessageTimeoutMs = 150000,
            RequestTimeoutMs = 15000,
            RetryBackoffMs = 1000,
            MaxInFlight = 5,
            Acks = Acks.All,
            AllowAutoCreateTopics = true
        };
    }

    public string GetTopicName() => config.TopicName!;

    public int MaxRetries() => config.ProducerMaxRetries;
}
