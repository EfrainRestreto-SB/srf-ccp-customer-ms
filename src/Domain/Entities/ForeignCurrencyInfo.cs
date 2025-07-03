namespace Domain.Entities.Customer;

public class ForeignCurrencyInfo
{
    public bool HandlesForeignCurrency { get; set; }
    public string? CurrencyType { get; set; }
    public decimal? ApproximateAmount { get; set; }
}
