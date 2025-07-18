using System.Text.Json.Serialization;

public class AddressInfoOutDto
{
    [JsonPropertyName("addressLine1")]
    public string AddressLine1 { get; set; } // E01NA2 - max-length 45 - alfanumérico

    [JsonPropertyName("addressLine2")]
    public string AddressLine2 { get; set; } // E01NA3 - max-length 45 - alfanumérico

    [JsonPropertyName("addressLine3")]
    public string AddressLine3 { get; set; } // E01NA4 - max-length 45 - alfanumérico

    [JsonPropertyName("city")]
    public string City { get; set; } // E01CTY - max-length 35 - alfanumérico

    [JsonPropertyName("cityCode")]
    public string CityCode { get; set; } // E01STE - max-length 4 - alfanumérico (Código ciudad)

    [JsonPropertyName("country")]
    public string Country { get; set; } // E01CTR - max-length 35 - alfanumérico

    [JsonPropertyName("postalCode")]
    public string PostalCode { get; set; } // E01ZPC - max-length 15 - alfanumérico

    [JsonPropertyName("residenceCountry")]
    public string ResidenceCountry { get; set; } // E01GEC - max-length 4 - alfanumérico (Código país, Tabla 03)

    [JsonPropertyName("currentResidenceYears")]
    public int CurrentResidenceYears { get; set; } // E01TVY - max-length 2 - numérico

    [JsonPropertyName("currentResidenceMonths")]
    public int CurrentResidenceMonths { get; set; } // E01TVM - max-length 2 - numérico

    [JsonPropertyName("housingType")]
    public string HousingType { get; set; } // E01TIP - max-length ? - alfanumérico (Tipo de vivienda)
}
