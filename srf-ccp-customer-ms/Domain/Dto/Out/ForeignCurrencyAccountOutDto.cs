namespace Domain.Dto.Out
{
    public class ForeignCurrencyAccountOutDto
    {
        public string AccountType { get; set; }
        public string AccountNumber { get; set; }
        public string InstitutionName { get; set; }
        public string InstitutionCountry { get; set; }
        public string ForeignCurrencyCode { get; set; }
        public string CurrencyValue { get; set; }
        public string FormOfPayment { get; set; }
        public string FormOfReceipt { get; set; }
        public string FormPaymentCountry { get; set; }
        public string FormReceiptCountry { get; set; }
    }
}
