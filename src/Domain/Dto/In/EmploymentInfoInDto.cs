using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In;

public class EmploymentInfoInDto
{
    [JsonPropertyName("companyName")]
    public string CompanyName { get; set; }

    [JsonPropertyName("companyAddress")]
    public string CompanyAddress { get; set; }

    [JsonPropertyName("jobPosition")]
    public string JobPosition { get; set; }

    [JsonPropertyName("previousCompany")]
    public string PreviousCompany { get; set; }

    [JsonPropertyName("employmentStartMonth")]
    public int EmploymentStartMonth { get; set; }

    [JsonPropertyName("employmentStartDay")]
    public int EmploymentStartDay { get; set; }

    [JsonPropertyName("employmentStartYear")]
    public int EmploymentStartYear { get; set; }

    [JsonPropertyName("companyCityCode")]
    public string CompanyCityCode { get; set; }

    [JsonPropertyName("companyCountry")]
    public string CompanyCountry { get; set; }

    [JsonPropertyName("contractType")]
    public string ContractType { get; set; }

    [JsonPropertyName("departmentCode")]
    public string DepartmentCode { get; set; }

    [JsonPropertyName("workPhone")]
    public string WorkPhone { get; set; }

    [JsonPropertyName("workExtension")]
    public string WorkExtension { get; set; }

    [JsonPropertyName("previousJobYears")]
    public int PreviousJobYears { get; set; }

    [JsonPropertyName("previousJobMonths")]
    public int PreviousJobMonths { get; set; }

    [JsonPropertyName("employeesCount")]
    public int EmployeesCount { get; set; }

    [JsonPropertyName("occupationCode")]
    public string OccupationCode { get; set; }

    [JsonPropertyName("dependentsCount")]
    public int DependentsCount { get; set; }
}
