namespace Domain.Models.Customer
{
    public class ForeignCurrencyAccountOutModel
    {
        public required string AccountType { get; set; }
        public required string AccountCountry { get; set; }
        public required string AccountBank { get; set; }
        public required string AccountNumber { get; set; }
        public required string Currency { get; set; }
        public required string AccountPurpose { get; set; }
    }
}
