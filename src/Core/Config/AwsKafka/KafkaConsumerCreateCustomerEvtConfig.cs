using Confluent.Kafka;
using Core.Config.SettingFile.AwsKafka;
using Domain.Interfaces.AwsKafka.Config;
using Microsoft.Extensions.Options;

namespace Core.Config.AwsKafka;

public class KafkaConsumerCreateCustomerEvtConfig(IOptions<KafkaCreateCustomerEvtJson> options) : IKafkaConsumerConfig
{
    private readonly KafkaCreateCustomerEvtJson config = options.Value;

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
