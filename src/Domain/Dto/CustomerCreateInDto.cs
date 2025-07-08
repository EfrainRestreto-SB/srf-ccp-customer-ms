using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Domain.Dto.In
{
    public class CustomerCreateInDto
    {
        public required object Addresses;
        public required object ContactInformation;
        public object Id;

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
        public required FinancialInfoInDto FinancialInfo { get; set; }

        [JsonPropertyName("employmentInfo")]
        public required EmploymentInfoInDto EmploymentInfo { get; set; }



        [JsonPropertyName("foreignCurrencyAccounts")]
        public required List<ForeignCurrencyAccountInDto> ForeignCurrencyAccounts { get; set; }

        [JsonPropertyName("gridInfo")]
        public required GridInfoInDto GridInfo { get; set; }

        [JsonPropertyName("interviewInfo")]
        public required InterviewInfoInDto InterviewInfo { get; set; }

        [JsonPropertyName("references")]
        public required List<ReferenceInDto> References { get; set; }

        [JsonPropertyName("descriptions")]
        public required DescriptionInfoInDto Descriptions { get; set; }

        public class GridInfoInDto
        {
        }
    }

    public class EmploymentInfoInDto
    {
    }

    public class FinancialInfoInDto
    {
    }
}
