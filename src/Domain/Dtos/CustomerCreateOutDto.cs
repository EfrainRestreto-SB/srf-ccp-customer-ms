using System.Text.Json.Serialization;

namespace Application.DTOs.Customer;

public class CustomerCreateOutDataDto
{
    [JsonPropertyName("customerNumber")]
    public string CustomerNumber { get; set; } = default!;
}
