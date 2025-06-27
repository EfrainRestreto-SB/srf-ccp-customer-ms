

using System.Text.Json.Serialization;

namespace Domain.Dtos.CreateSavingsAccount.Out;

public class CustomerCreateOutDto
{
    [JsonPropertyName("datosGenerales")]
    public DatosGeneralesOutDto? DatosGenerales { get; set; }

    [JsonPropertyName("datosUbicacion")]
    public DatosUbicacionOutDto? DatosUbicacion { get; set; }
}
