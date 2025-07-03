

using System.Text.Json.Serialization;

namespace Domain.Dtos.CreateSavingsAccount.Out;

public class FechaOutDto

{

    [JsonPropertyName("dia")]
    public string? Dia { get; set; }

    [JsonPropertyName("mes")]
    public string? Mes { get; set; }

    [JsonPropertyName("ano")]
    public string? Ano { get; set; }

}
