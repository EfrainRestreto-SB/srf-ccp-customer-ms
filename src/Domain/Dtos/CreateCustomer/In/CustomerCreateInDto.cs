

using System.Text.Json.Serialization;

namespace Domain.Dtos.CreateSavingsAccount.In;

public class CustomerCreateInDto
{
    [JsonPropertyName("datosGenerales")]
    public DatosGeneralesInDto? DatosGenerales { get; set; }

    [JsonPropertyName("datosUbicacion")]
    public DatosUbicacionInDto? DatosUbicacion { get; set; }
}
