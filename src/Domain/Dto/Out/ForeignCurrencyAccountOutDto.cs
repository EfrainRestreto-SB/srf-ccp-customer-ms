using System.Text.Json.Serialization;

namespace Domain.Dto.In
{
    public class ForeignCurrencyAccountOutDto
    {
        public object AccountInstitution;
        public object AccountCurrency;
        public object AccountState;
        public object AccountCity;
        public object AccountDepartment;
        public object AccountAddress;
        public object AccountPhone;
        public object FirstAccountHolderName;

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
