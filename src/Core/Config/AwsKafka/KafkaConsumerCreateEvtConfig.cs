using Confluent.Kafka;
using Core.Config.SettingFiles.AwsKafka;
using Domain.Interfaces.AwsKafka.Config;
using Microsoft.Extensions.Options;

namespace Core.Config.AwsKafka;

public class KafkaConsumerCreateCdtEvtConfig(IOptions<KafkaCreateCdtEvtJson> options) : IKafkaConsumerConfig
{
    private readonly KafkaCreateCdtEvtJson config = options.Value;


    public ConsumerConfig GetConsumerConfig() => new()
    {
        BootstrapServers = config.BootstrapServers,
        GroupId = config.GroupId,
        AutoOffsetReset = AutoOffsetReset.Earliest,
        EnableAutoOffsetStore = false,
        EnableAutoCommit = false,
        SaslMechanism = SaslMechanism.OAuthBearer,
        SecurityProtocol = SecurityProtocol.SaslSsl,
        PartitionAssignmentStrategy = PartitionAssignmentStrategy.CooperativeSticky
    };

    public string GetTopicName() => config.TopicName!;
}