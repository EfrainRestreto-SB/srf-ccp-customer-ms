

using System.Text.Json.Serialization;

namespace Domain.Dtos.CreateSavingsAccount.In;

public class DatosUbicacionInDto
{

    [JsonPropertyName("codigoDpto")]
    public string? CodigoDpto { get; set;}

    [JsonPropertyName("codigoMunicipio")]
    public string? CodigoMunicipio { get; set;}

    [JsonPropertyName("direccion")]
    public string? Direccion { get; set;}

    [JsonPropertyName("tipoTelefono")]
    public string? TipoTelefono { get; set;}

    [JsonPropertyName("numeroTelefonoPrincipal")]
    public string? NumeroTelefonoPrincipal { get; set;}

    [JsonPropertyName("informacionExpedicionIdentificacion")]
    public InformacionExpedicionIdentificacionInDto? InformacionExpedicionIdentificacion { get; set;}

}
