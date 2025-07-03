

using System.Text.Json.Serialization;

namespace Domain.Dtos.CreateSavingsAccount.In;

public class InformacionExpedicionIdentificacionInDto
{
    [JsonPropertyName("fechaExpiracion")]
    public FechaInDto? FechaExpedicion{get; set;}

    [JsonPropertyName("lugar")]
    public string? Lugar {get; set;}
}
