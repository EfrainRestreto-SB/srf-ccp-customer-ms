

using System.Text.Json.Serialization;

namespace Domain.Dtos.CreateSavingsAccount.In;

public class DatosGeneralesInDto
{
    [JsonPropertyName("numeroId")]
    public string? NumeroId { get; set; }

    [JsonPropertyName("tipoId")]
    public string? TipoId { get; set; }

    [JsonPropertyName("primerNombre")]
    public string? PrimerNombre{ get; set; }

    [JsonPropertyName("segundoNombre")]
    public string? SegundoNombre{ get; set; }

    [JsonPropertyName("primerApellido")]
    public string? PrimerApellido{ get; set; }

    [JsonPropertyName("segundoApellido")]
    public string? SegundoApellido{ get; set; }

    [JsonPropertyName("sexo")]
    public string? Sexo { get; set; }

    [JsonPropertyName("fechaNacimiento")]
    public FechaInDto? FechaNacimiento{ get; set; }

    [JsonPropertyName("codigoPaisNacimiento")]
    public string? CodigoPaisNacimiento{ get; set; }

    [JsonPropertyName("CodigoDptoNacimiento")]
    public string? CodigoDptoNacimiento{ get; set; }

    [JsonPropertyName("codigoCiudadNacimiento")]
    public string? CodigoCiudadNacimiento{ get; set; }

    [JsonPropertyName("correoElectronico")]
    public string? CorreoElectronico{ get; set; }
}
