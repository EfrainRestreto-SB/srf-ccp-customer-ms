namespace Application.Utils;

public static class KafkaTopicHelper
{
    public static string GetCustomerTopic(string environment)
    {
        return environment.ToLower() switch
        {
            "development" => "dev-customer-create",
            "qa" => "qa-customer-create",
            "production" => "prod-customer-create",
            _ => "default-customer-topic"
        };
    }
}
