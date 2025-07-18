using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In;

public class BirthInfoInDto
{
    [JsonPropertyName("birthMonth")]
    public int? BirthMonth { get; set; }

    [JsonPropertyName("birthDay")]
    public int? BirthDay { get; set; }

    [JsonPropertyName("birthYear")]
    public int? BirthYear { get; set; }

    [JsonPropertyName("birthCountry")]
    public string BirthCountry { get; set; }

    [JsonPropertyName("birthDepartment")]
    public string BirthDepartment { get; set; }

    [JsonPropertyName("birthCity")]
    public string BirthCity { get; set; }
}
