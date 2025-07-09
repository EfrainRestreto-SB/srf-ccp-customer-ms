using Domain.Dto.In;
using Domain.Dtos.Customer.In;
using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In
{
    public class CustomerCreateInDto
    {
        public object ForeignCurrencyAccount;

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

        public class EmploymentInfoInDto
        {
            public readonly object EmploymentType;
            public object CompanyName;
            public object CompanyNit;
            public object Phone;
            public object EmploymentStatus;
            public object EmploymentStartDate;
            public object JobTitle;
            public object EconomicSector;
            public object EconomicActivity;
            public object EmploymentContractType;
            public object JobAddress;
        }
    }
}
