using Domain.Dtos.CreateCustomer.In;
using System.Text.Json.Serialization;


namespace Domain.Dtos
{
    public class CustomerCreateInDto : CustomerCreateInDtoBase
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("birthInfo")]
        public BirthInfoInDto? BirthInfo { get; set; }

        [JsonPropertyName("descriptions")]
        public DescriptionsInDto? Descriptions { get; set; }

        [JsonPropertyName("employmentInfo")]
        public EmploymentInfoInDto? EmploymentInfo { get; set; }

        [JsonPropertyName("financialInfo")]
        public FinancialInfoInDto? FinancialInfo { get; set; }

        [JsonPropertyName("foreignCurrencyInfo")]
        public ForeignCurrencyInfoInDto? ForeignCurrencyInfo { get; set; }

        [JsonPropertyName("identification")]
        public IdentificationInDto? Identification { get; set; }

        [JsonPropertyName("interviewInfo")]
        public InterviewInfoInDto? InterviewInfo { get; set; }

        [JsonPropertyName("bankingInfo")]
        public BankingInfoInDto? BankingInfo { get; set; }

        [JsonPropertyName("references")]
        public ReferencesInDto? References { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is CustomerCreateInDto dto &&
                   EqualityComparer<BasicInformationInDto?>.Default.Equals(BasicInformation, dto.BasicInformation);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(BasicInformation);
        }
    }
}

namespace Domain
{
    class BasicInformationInDto
    {
    }

    class BirthInfoInDto
    {
    }

    class DescriptionsInDto
    {
    }

    class ReferencesInDto
    {
    }
}