using System.Text.Json.Serialization;

namespace Core.Events;

public class KafkaCreateCustomerEvtJson
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("basicInformation")]
    public BasicInformationKafka? BasicInformation { get; set; }

    [JsonPropertyName("identification")]
    public IdentificationKafka? Identification { get; set; }

    [JsonPropertyName("birthInfo")]
    public BirthInfoKafka? BirthInfo { get; set; }

    [JsonPropertyName("contactInfo")]
    public ContactInfoKafka? ContactInfo { get; set; }

    [JsonPropertyName("employmentInfo")]
    public EmploymentInfoKafka? EmploymentInfo { get; set; }

    [JsonPropertyName("financialInfo")]
    public FinancialInfoKafka? FinancialInfo { get; set; }

    [JsonPropertyName("foreignCurrencyInfo")]
    public ForeignCurrencyInfoKafka? ForeignCurrencyInfo { get; set; }

    [JsonPropertyName("interviewInfo")]
    public InterviewInfoKafka? InterviewInfo { get; set; }

    [JsonPropertyName("bankingInfo")]
    public BankingInfoKafka? BankingInfo { get; set; }

    [JsonPropertyName("descriptions")]
    public DescriptionsKafka? Descriptions { get; set; }

    [JsonPropertyName("references")]
    public ReferencesKafka? References { get; set; }

    public class EmploymentInfoKafka
    {
    }

    public class ContactInfoKafka
    {
    }

    public class BirthInfoKafka
    {
    }

    public class FinancialInfoKafka
    {
    }

    public class BasicInformationKafka
    {
    }

    public class IdentificationKafka
    {
    }

    public class ReferencesKafka
    {
    }

    public class DescriptionsKafka
    {
    }

    public class BankingInfoKafka
    {
    }

    public class InterviewInfoKafka
    {
    }

    public class ForeignCurrencyInfoKafka
    {
    }
}
