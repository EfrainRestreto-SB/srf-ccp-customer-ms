using Domain.Dtos.Out;
using System.Text.Json.Serialization;

namespace Domain.Dtos;

public class CustomerCreateOutDto
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("basicInformation")]
    public string ?BasicInformationOutDto { get; set; }

    [JsonPropertyName("birthInfo")]
    public string? BirthInfo { get; set; }

    [JsonPropertyName("contactInfo")]
    public string? ContactInfo { get; set; }

    [JsonPropertyName("descriptions")]
    public string? Descriptions { get; set; }

    [JsonPropertyName("employmentInfo")]
    public string? EmploymentInfo { get; set; }

    [JsonPropertyName("financialInfo")]
    public string? FinancialInfo { get; set; }

    [JsonPropertyName("foreignCurrencyInfo")]
    public string? ForeignCurrencyInfo { get; set; }

    [JsonPropertyName("identification")]
    public string? Identification { get; set; }

    [JsonPropertyName("interviewInfo")]
    public string? InterviewInfo { get; set; }

    [JsonPropertyName("bankingInfo")]
    public string? BankingInfo { get; set; }

    [JsonPropertyName("references")]
    public string? References { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }
}
