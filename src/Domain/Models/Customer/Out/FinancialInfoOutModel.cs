namespace Domain.Models.Customer
{
    public class FinancialInfoOutModel
    {
        public required string Income { get; set; }
        public required string OtherIncome { get; set; }
        public required string IncomeSource { get; set; }
        public required string OtherIncomeSource { get; set; }
        public required string IncomeFrequency { get; set; }
        public required string TotalIncome { get; set; }
        public required string TotalExpenses { get; set; }
        public required string FundsOrigin { get; set; }
        public required string FundsUse { get; set; }
        public required string FundsOriginDescription { get; set; }
        public required string FundsUseDescription { get; set; }
    }
}
