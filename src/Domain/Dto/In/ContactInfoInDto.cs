using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In;

public class ContactInfoInDto
{
    [JsonPropertyName("emailType")]
    public string EmailType { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("phoneType")]
    public string PhoneType { get; set; }

    [JsonPropertyName("mainPhone")]
    public string MainPhone { get; set; }

    [JsonPropertyName("phoneExtension")]
    public string PhoneExtension { get; set; }
}
