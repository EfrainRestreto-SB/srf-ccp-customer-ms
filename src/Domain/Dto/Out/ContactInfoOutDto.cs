using System.Text.Json.Serialization;

namespace Domain.Dto.In
{
    public class ContactInfoOutDto
    {
        [JsonPropertyName("emailType")]
        public string EmailType { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("phoneType")]
        public string PhoneType { get; set; }

        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonPropertyName("phoneDescription")]
        public string PhoneDescription { get; set; }
    }
}
