using System.Text.Json.Serialization;

public class ContactInfoOutDto
{
    [JsonPropertyName("emailType")]
    public string EmailType { get; set; } // E01IAT - max-length 4 - alfanumérico

    [JsonPropertyName("email")]
    public string Email { get; set; } // E01IAD - max-length 60 - alfanumérico

    [JsonPropertyName("phoneType")]
    public string PhoneType { get; set; } // E01PHT - max-length 4 - alfanumérico (tabla DO)

    [JsonPropertyName("mainPhone")]
    public string MainPhone { get; set; } // E01PHO - max-length 60 - alfanumérico

    [JsonPropertyName("phoneExtension")]
    public string PhoneExtension { get; set; } // E01PHX - max-length 10 - alfanumérico
}
