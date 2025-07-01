namespace Domain.Models.CreateCustomer.Out;

public class ForeignCurrencyInfoOutModel
{
    public string? HasForeignCurrencyIncome { get; set; }
    public string? ForeignCurrencyIncomeSource { get; set; }
    public string? ForeignCurrencyDestination { get; set; }
}
