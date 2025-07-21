using System.Text.Json.Serialization;

namespace Application.Dtos.Customer.Create.Out;

public class BirthInfoOutDto
{
    [JsonPropertyName("birthMonth")]
    public int? BirthMonth { get; set; } // E01BDM - MES

    [JsonPropertyName("birthDay")]
    public int? BirthDay { get; set; } // E01BDD - DÍA

    [JsonPropertyName("birthYear")]
    public int? BirthYear { get; set; } // E01BDY - AÑO

    [JsonPropertyName("birthCountry")]
    public string? BirthCountry { get; set; } // E01N5P - PAÍS NACIMIENTO

    [JsonPropertyName("birthDepartment")]
    public string? BirthDepartment { get; set; } // E01N5D - DEPARTAMENTO NACIMIENTO

    [JsonPropertyName("birthCity")]
    public string? BirthCity { get; set; } // E01N5C - CIUDAD NACIMIENTO
}
