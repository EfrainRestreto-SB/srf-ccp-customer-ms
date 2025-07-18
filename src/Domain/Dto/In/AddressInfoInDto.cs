using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In;

public class AddressInfoInDto
{
    [JsonPropertyName("addressLine1")]
    public string AddressLine1 { get; set; }

    [JsonPropertyName("addressLine2")]
    public string AddressLine2 { get; set; }

    [JsonPropertyName("addressLine3")]
    public string AddressLine3 { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonPropertyName("cityCode")]
    public string CityCode { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; }

    [JsonPropertyName("postalCode")]
    public string PostalCode { get; set; }

    [JsonPropertyName("residenceCountry")]
    public string ResidenceCountry { get; set; }

    [JsonPropertyName("currentResidenceYears")]
    public int CurrentResidenceYears { get; set; }

    [JsonPropertyName("currentResidenceMonths")]
    public int CurrentResidenceMonths { get; set; }

    [JsonPropertyName("housingType")]
    public string HousingType { get; set; }
}
