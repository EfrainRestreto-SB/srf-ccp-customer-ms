

using System.Text.Json.Serialization;

namespace Domain.Dtos.CreateSavingsAccount.Out;

public class InformacionExpedicionIdentificacionOutDto
{
    [JsonPropertyName("fechaExpedicion")]
    public FechaOutDto? FechaExpedicion{get; set;}

    [JsonPropertyName("lugar")]
    public string? Lugar {get; set;}
}
