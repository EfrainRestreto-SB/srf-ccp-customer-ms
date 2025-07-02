using Domain.Dtos.CreateCustomer.In;
using System.Text.Json.Serialization;

namespace Domain.Dtos
{
    public class CustomerCreateInDto
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

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

        public class ReferencesInDto
        {
        }

        public class DescriptionsInDto
        {
        }
    }
}

public class EmploymentInfoInDto // Cambiado de 'internal' a 'public'
{
    public string? comanyName { get; set; }
    public string? companyAdress { get; set; }
    public string? jobPosition { get; set; }
    public string? previusCompany { get; set; }
    public string? employmentStartMonth { get; set; }
    public string? employmentStartDay { get; set; }
    public string? employmentStartYears { get; set; }
    public string? comapanyCityCode { get; set; }
    public string? companyCountry { get; set; }
    public string? contractType { get; set; }
    public string? DepartamentCode { get; set; }
    public string? workCode { get; set; }
    public string? workPhone { get; set; }
    public string? workExtencion { get; set; }
    public string? previousJobYears { get; set; }
    public string? previousJobMonth { get; set; }
    public string? employessCount { get; set; }
    public string? ocupationCode { get; set; }
    public string? dependentsCounts { get; set; }
}