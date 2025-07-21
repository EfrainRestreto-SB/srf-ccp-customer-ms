namespace Core.Config.SettingFiles.AwsKafka;

public class KafkaCreateCustomerEvtJson
{
    public int ParallelKafkaConsumers { get; set; }
    public string? TopicName { get; set; }
    public string? BootstrapServers { get; set; }
    public string? GroupId { get; set; }
}
