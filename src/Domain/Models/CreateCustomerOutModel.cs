using System.Text.Json.Serialization;

namespace Domain.Models.Customer.Out;

public class CreateCustomerOutModel
{
	[JsonPropertyName("customerId")]
	public string? CustomerId { get; set; }

	[JsonPropertyName("status")]
	public string? Status { get; set; }

	[JsonPropertyName("message")]
	public string? Message { get; set; }

	[JsonPropertyName("createdAt")]
	public DateTime CreatedAt { get; set; }
}
