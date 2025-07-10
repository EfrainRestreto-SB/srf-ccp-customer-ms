using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In
{
    public class ContactInfoInDto
    {
        public object PhoneNumber;
        public object PhoneDescription;

        [JsonPropertyName("emailType")]
        public string EmailType { get; set; }           // E01IAT

        [JsonPropertyName("email")]
        public string Email { get; set; }               // E01IAD

        [JsonPropertyName("phoneType")]
        public string PhoneType { get; set; }           // E01PHT

        [JsonPropertyName("mainPhone")]
        public string MainPhone { get; set; }           // E01PHO

        [JsonPropertyName("phoneExtension")]
        public string PhoneExtension { get; set; }      // E01PHX
    }
}
