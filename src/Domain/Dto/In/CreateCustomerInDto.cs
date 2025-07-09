using System.Text.Json.Serialization;
using static Domain.Dtos.Customer.In.CustomerCreateInDto;

namespace Domain.Dto.In
{
    public class CreateCustomerIDto
    {
        [JsonPropertyName("basicInformation")]
        public required BasicInformationInDto BasicInformation { get; set; }

        [JsonPropertyName("identification")]
        public required IdentificationInDto Identification { get; set; }

        [JsonPropertyName("birthInfo")]
        public required BirthInfoInDto BirthInfo { get; set; }

        [JsonPropertyName("contactInfo")]
        public required ContactInfoInDto ContactInfo { get; set; }

        [JsonPropertyName("addressInfo")]
        public required AddressInfoInDto AddressInfo { get; set; }

        [JsonPropertyName("financialInfo")]
        public required FinancialInfoDto FinancialInfo { get; set; }

        [JsonPropertyName("employmentInfo")]
        public required EmploymentInfoInDto EmploymentInfo { get; set; }

        [JsonPropertyName("foreignCurrencyAccounts")]
        public required List<ForeignCurrencyAccountInDto> ForeignCurrencyAccounts { get; set; }

        [JsonPropertyName("interviewInfo")]
        public required InterviewInfoInDto InterviewInfo { get; set; }

        [JsonPropertyName("references")]
        public required List<ReferenceInDto> References { get; set; }

        [JsonPropertyName("descriptionInfo")]
        public required DescriptionInfoInDto DescriptionInfo { get; set; }
    }
}
