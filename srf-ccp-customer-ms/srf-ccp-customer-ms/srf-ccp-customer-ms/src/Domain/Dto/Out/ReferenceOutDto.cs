using System.Text.Json.Serialization;

public class ReferencesOutDto
{
    [JsonPropertyName("referenceType")]
    public required string ReferenceType { get; set; }

    [JsonPropertyName("companyName")]
    public required string CompanyName { get; set; }

    [JsonPropertyName("contactName")]
    public required string ContactName { get; set; }

    [JsonPropertyName("firstLastName")]
    public required string FirstLastName { get; set; }

    [JsonPropertyName("secondLastName")]
    public required string SecondLastName { get; set; }

    [JsonPropertyName("countryCode")]
    public required string CountryCode { get; set; }

    [JsonPropertyName("departmentCode")]
    public required string DepartmentCode { get; set; }

    [JsonPropertyName("cityCode")]
    public required string CityCode { get; set; }

    [JsonPropertyName("landlinePhone")]
    public required string LandlinePhone { get; set; }

    [JsonPropertyName("mobilePhone")]
    public required string MobilePhone { get; set; }

    [JsonPropertyName("phoneExtension")]
    public required string PhoneExtension { get; set; }

    [JsonPropertyName("relationship")]
    public required string Relationship { get; set; }
}
