using System.Text.Json.Serialization;

namespace Domain.Dto.In
{
    public class ForeignCurrencyAccountInDto
    {
        public readonly object FormReceiptCountry;
        public object InstitutionName;
        public object FormPaymentCountry;
        public object FormOfReceipt;
        public object FormOfPayment;
        public object ForeignCurrencyCode;
        public object CurrencyValue;
        public object InstitutionCountry;

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
