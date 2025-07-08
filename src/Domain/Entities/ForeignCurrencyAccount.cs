namespace Domain.Entities.Customer
{
    public class ForeignCurrencyAccount
    {
        public string AccountType { get; set; }
        public string AccountCountry { get; set; }
        public string AccountBank { get; set; }
        public string AccountNumber { get; set; }
        public string Currency { get; set; }
        public string AccountPurpose { get; set; }
    }
}
