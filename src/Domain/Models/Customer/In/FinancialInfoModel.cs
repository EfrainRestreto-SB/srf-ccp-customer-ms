namespace Domain.Models.Customer
{
    public class FinancialInfoOutModel
    {
        public string Income { get; set; }
        public string OtherIncome { get; set; }
        public string IncomeSource { get; set; }
        public string OtherIncomeSource { get; set; }
        public string IncomeFrequency { get; set; }
        public string TotalIncome { get; set; }
        public string TotalExpenses { get; set; }
        public string FundsOrigin { get; set; }
        public string FundsUse { get; set; }
        public string FundsOriginDescription { get; set; }
        public string FundsUseDescription { get; set; }
    }
}
