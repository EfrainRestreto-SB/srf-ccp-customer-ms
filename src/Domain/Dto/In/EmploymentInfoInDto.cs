using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In
{
    public class EmploymentInfoInDto
    {
        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }            // E01CP1

        [JsonPropertyName("companyAddress")]
        public string CompanyAddress { get; set; }         // E01CP2

        [JsonPropertyName("jobPosition")]
        public string JobPosition { get; set; }            // E01CP3

        [JsonPropertyName("previousCompany")]
        public string PreviousCompany { get; set; }        // E01NM4

        [JsonPropertyName("employmentStartMonth")]
        public string EmploymentStartMonth { get; set; }   // E01SWM

        [JsonPropertyName("employmentStartDay")]
        public string EmploymentStartDay { get; set; }     // E01SWD

        [JsonPropertyName("employmentStartYear")]
        public string EmploymentStartYear { get; set; }    // E01SWY

        [JsonPropertyName("companyCityCode")]
        public string CompanyCityCode { get; set; }        // E01F01

        [JsonPropertyName("companyCountry")]
        public string CompanyCountry { get; set; }         // E01F02

        [JsonPropertyName("contractType")]
        public string ContractType { get; set; }           // E01EPT

        [JsonPropertyName("departmentCode")]
        public string DepartmentCode { get; set; }         // E01FC4

        [JsonPropertyName("workPhone")]
        public string WorkPhone { get; set; }              // E01PHO1

        [JsonPropertyName("workExtension")]
        public string WorkExtension { get; set; }          // E01EX01

        [JsonPropertyName("previousJobYears")]
        public string PreviousJobYears { get; set; }       // E01TIY

        [JsonPropertyName("previousJobMonths")]
        public string PreviousJobMonths { get; set; }      // E01TIM

        [JsonPropertyName("employeesCount")]
        public string EmployeesCount { get; set; }         // E01NEM

        [JsonPropertyName("occupationCode")]
        public string OccupationCode { get; set; }         // E01ALB

        [JsonPropertyName("dependentsCount")]
        public string DependentsCount { get; set; }        // E01NSO
    }
}
