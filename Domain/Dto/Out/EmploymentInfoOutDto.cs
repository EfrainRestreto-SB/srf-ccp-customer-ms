using System.Text.Json.Serialization;

namespace Application.Dtos.Customer.Create.Out;

public class EmploymentInfoOutDto
{
    [JsonPropertyName("companyName")]
    public string? CompanyName { get; set; } // E01CP1

    [JsonPropertyName("companyAddress")]
    public string? CompanyAddress { get; set; } // E01CP2

    [JsonPropertyName("jobPosition")]
    public string? JobPosition { get; set; } // E01CP3

    [JsonPropertyName("previousCompany")]
    public string? PreviousCompany { get; set; } // E01NM4

    [JsonPropertyName("employmentStartMonth")]
    public int? EmploymentStartMonth { get; set; } // E01SWM

    [JsonPropertyName("employmentStartDay")]
    public int? EmploymentStartDay { get; set; } // E01SWD

    [JsonPropertyName("employmentStartYear")]
    public int? EmploymentStartYear { get; set; } // E01SWY

    [JsonPropertyName("companyCityCode")]
    public string? CompanyCityCode { get; set; } // E01F01

    [JsonPropertyName("companyCountry")]
    public string? CompanyCountry { get; set; } // E01F02

    [JsonPropertyName("contractType")]
    public string? ContractType { get; set; } // E01EPT

    [JsonPropertyName("departmentCode")]
    public string? DepartmentCode { get; set; } // E01FC4

    [JsonPropertyName("workPhone")]
    public string? WorkPhone { get; set; } // E01PHO1

    [JsonPropertyName("workExtension")]
    public string? WorkExtension { get; set; } // E01EX01

    [JsonPropertyName("previousJobYears")]
    public int? PreviousJobYears { get; set; } // E01TIY

    [JsonPropertyName("previousJobMonths")]
    public int? PreviousJobMonths { get; set; } // E01TIM

    [JsonPropertyName("employeesCount")]
    public int? EmployeesCount { get; set; } // E01NEM

    [JsonPropertyName("occupationCode")]
    public string? OccupationCode { get; set; } // E01ALB

    [JsonPropertyName("dependentsCount")]
    public int? DependentsCount { get; set; } // E01NSO
}
