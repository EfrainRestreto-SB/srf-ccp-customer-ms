using System.Text.Json.Serialization;

namespace Domain.Dtos.CreateCustomer.In;

public class AddressDto
{
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("department")]
    public string? Department { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("neighborhood")]
    public string? Neighborhood { get; set; }

    [JsonPropertyName("mainStreetType")]
    public string? MainStreetType { get; set; }

    [JsonPropertyName("mainStreetNumber")]
    public string? MainStreetNumber { get; set; }

    [JsonPropertyName("secondaryStreetNumber")]
    public string? SecondaryStreetNumber { get; set; }

    [JsonPropertyName("buildingNumber")]
    public string? BuildingNumber { get; set; }

    [JsonPropertyName("complement")]
    public string? Complement { get; set; }

    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    [JsonPropertyName("residenceType")]
    public string? ResidenceType { get; set; }

    [JsonPropertyName("residenceTime")]
    public string? ResidenceTime { get; set; }

    [JsonPropertyName("addressZone")]
    public string? AddressZone { get; set; }
}
