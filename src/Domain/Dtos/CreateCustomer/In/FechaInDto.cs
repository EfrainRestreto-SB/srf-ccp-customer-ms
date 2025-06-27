

using System.Text.Json.Serialization;

namespace Domain.Dtos.CreateSavingsAccount.In;

public class FechaInDto
{
    [JsonPropertyName("dia")]
    public string? Dia { get; set; }
    
    [JsonPropertyName("mes")]
    public string? Mes { get; set; }
    
    [JsonPropertyName("ano")]
    public string? Ano { get; set; }

}
