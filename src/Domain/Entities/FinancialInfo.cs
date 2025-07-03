namespace Domain.Entities.Customer;

public class FinancialInfo
{
    public decimal MonthlyIncome { get; set; }
    public decimal MonthlyExpenses { get; set; }
    public string IncomeSource { get; set; } = default!;
}
