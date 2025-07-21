using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In;

public class ReferenceInfoInDto
{
    [JsonPropertyName("referenceType")]
    public string ReferenceType { get; set; }

    [JsonPropertyName("companyName")]
    public string CompanyName { get; set; }

    [JsonPropertyName("contactName")]
    public string ContactName { get; set; }

    [JsonPropertyName("firstLastName")]
    public string FirstLastName { get; set; }

    [JsonPropertyName("secondLastName")]
    public string SecondLastName { get; set; }

    [JsonPropertyName("countryCode")]
    public string CountryCode { get; set; }

    [JsonPropertyName("departmentCode")]
    public string DepartmentCode { get; set; }

    [JsonPropertyName("cityCode")]
    public string CityCode { get; set; }

    [JsonPropertyName("landlinePhone")]
    public string LandlinePhone { get; set; }

    [JsonPropertyName("mobilePhone")]
    public string MobilePhone { get; set; }

    [JsonPropertyName("phoneExtension")]
    public string PhoneExtension { get; set; }

    [JsonPropertyName("relationship")]
    public string Relationship { get; set; }
}
