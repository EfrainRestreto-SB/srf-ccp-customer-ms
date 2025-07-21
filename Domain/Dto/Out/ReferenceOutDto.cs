using System.Text.Json.Serialization;

public class ReferenceOutDto
{
    [JsonPropertyName("referenceType")]
    public string ReferenceType { get; set; } // TIPO DE REFERENCIA (P=Personal, C=Comercial) max-length 1 tipo ALFANUMERICO correspondiente al campo E01TIR del AS400

    [JsonPropertyName("fullName")]
    public string FullName { get; set; } // NOMBRE COMPLETO max-length 45 tipo ALFANUMERICO correspondiente al campo E01NRF del AS400

    [JsonPropertyName("relationship")]
    public string Relationship { get; set; } // PARENTESCO / RELACION max-length 45 tipo ALFANUMERICO correspondiente al campo E01RRF del AS400

    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; } // TELEFONO max-length 15 tipo NUMERICO correspondiente al campo E01TRF del AS400

    [JsonPropertyName("address")]
    public string Address { get; set; } // DIRECCION max-length 45 tipo ALFANUMERICO correspondiente al campo E01DRF del AS400

    [JsonPropertyName("cityCode")]
    public string CityCode { get; set; } // CODIGO CIUDAD max-length 4 tipo ALFANUMERICO correspondiente al campo E01CRF del AS400

    [JsonPropertyName("country")]
    public string Country { get; set; } // PAIS max-length 4 tipo ALFANUMERICO correspondiente al campo E01PRF del AS400
}
