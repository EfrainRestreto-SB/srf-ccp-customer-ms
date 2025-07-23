using Application.Dtos.Customer.Create.Out;
using Domain.Dto.In;
using Domain.Dto.Out;
using System.Text.Json.Serialization;

public class CreateCustomerOutDto
{
    [JsonPropertyName("basicOutformation")]
    public required BasicInformationOutDto BasicInformation { get; set; }

    [JsonPropertyName("identification")]
    public required IdentificationOutDto Identification { get; set; }

    [JsonPropertyName("contactInfo")]
    public required ContactInfoOutDto ContactInfo { get; set; }

    [JsonPropertyName("addressInfo")]
    public required AddressInfoOutDto AddressInfo { get; set; }

    [JsonPropertyName("financialInfo")]
    public required FinancialInfoOutDto FinancialInfo { get; set; }

    [JsonPropertyName("employmentInfo")]
    public required EmploymentInfoOutDto EmploymentInfo { get; set; }

    [JsonPropertyName("foreignCurrencyInfo")]
    public required ForeignCurrencyInfoOutDto ForeignCurrencyInfo { get; set; }

    [JsonPropertyName("bankingInfo")]
    public required BankingInfoOutDto BankingInfo { get; set; }

    [JsonPropertyName("interviewInfo")]
    public required InterviewInfoOutDto InterviewInfo { get; set; }

    [JsonPropertyName("references")]
    public required ReferencesOutDto References { get; set; }

    [JsonPropertyName("descriptions")]
    public required DescriptionsOutDto Descriptions { get; set; }

    [JsonPropertyName("birthInfo")]
    public required BirthInfoOutDto birthInfo { get; set; }
}
