using System.Text.Json.Serialization;

namespace Domain.Models;

public class CustomerOutModel
{
    [JsonPropertyName("nombreCompleto")]
    public string? NombreCompleto { get; set; }

    [JsonPropertyName("correo")]
    public string? Correo { get; set; }
}
