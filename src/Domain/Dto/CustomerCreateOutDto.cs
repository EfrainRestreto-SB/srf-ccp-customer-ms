using System.Text.Json.Serialization;
using Domain.Dto.In;

namespace SrfCcpCustomerMs.Domain.Dtos.In
{
    public class CustomerCreateOutDto
    {
        [JsonPropertyName("basicInformation")]
        public required BasicInformationOutDto BasicInformation { get; set; }

        [JsonPropertyName("identification")]
        public required IdentificationOutDto Identification { get; set; }

        [JsonPropertyName("birthInfo")]
        public required BirthInfoOutDto BirthInfo { get; set; }

        [JsonPropertyName("contactInfo")]
        public required ContactInfoOutDto ContactInfo { get; set; }

        [JsonPropertyName("addressInfo")]
        public required AddressInfoOutDto AddressInfo { get; set; }

        [JsonPropertyName("financialInfo")]
        public required FinancialInfoOutDto FinancialInfo { get; set; }

        [JsonPropertyName("employmentInfo")]
        public required EmploymentInfoOutDto EmploymentInfo { get; set; }

        [JsonPropertyName("foreignCurrencyAccount")]
        public required ForeignCurrencyAccountOutDto ForeignCurrencyAccount { get; set; }

        [JsonPropertyName("interviewInfo")]
        public required InterviewInfoOutDto InterviewInfo { get; set; }

        [JsonPropertyName("references")]
        public required List<ReferenceOutDto> References { get; set; }

        [JsonPropertyName("descriptions")]
        public required DescriptionInfoOutDto Descriptions { get; set; }
    }
}
