using Application.Dtos.Customer.Create.Out;
using Domain.Dto.In;
using Domain.Dto.Out;
using System.Text.Json.Serialization;

public class CreateCustomerOutDto
{
    [JsonPropertyName("basicOutformation")]
    public BasicInformationOutDto BasicInformation { get; set; }

    [JsonPropertyName("identification")]
    public IdentificationOutDto Identification { get; set; }



    [JsonPropertyName("contactInfo")]
    public ContactInfoOutDto ContactInfo { get; set; }

    [JsonPropertyName("addressInfo")]
    public AddressInfoOutDto AddressInfo { get; set; }

    [JsonPropertyName("financialInfo")]
    public FinancialInfoOutDto FinancialInfo { get; set; }

    [JsonPropertyName("employmentInfo")]
    public EmploymentInfoOutDto EmploymentInfo { get; set; }

    [JsonPropertyName("foreignCurrencyInfo")]
    public ForeignCurrencyInfoOutDto ForeignCurrencyInfo { get; set; }

    [JsonPropertyName("bankingInfo")]
    public BankingInfoOutDto BankingInfo { get; set; }

    [JsonPropertyName("interviewInfo")]
    public InterviewInfoOutDto InterviewInfo { get; set; }

    [JsonPropertyName("references")]
    public ReferenceOutDto References { get; set; }

    [JsonPropertyName("descriptions")]
    public DescriptionsOutDto Descriptions { get; set; }
}
