namespace Core.Config.SettingFiles.AwsKafka;

public class KafkaCreateCdtCustomerJson
{
    public string? BootstrapServers { get; set; }
    public string? TopicName { get; set; }
    public int ProducerMaxRetries { get; set; }
}
