using System.Text.Json.Serialization;

namespace Domain.Dto.In
{
    public class ForeignCurrencyAccountInDto
    {
        [JsonPropertyName("accountType")]
        public string AccountType { get; set; }

        [JsonPropertyName("accountCountry")]
        public string AccountCountry { get; set; }

        [JsonPropertyName("accountBank")]
        public string AccountBank { get; set; }

        [JsonPropertyName("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("accountPurpose")]
        public string AccountPurpose { get; set; }
    }
}
