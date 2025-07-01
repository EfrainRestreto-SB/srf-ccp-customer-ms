namespace Domain.Models.CreateCustomer.In;

public class ForeignCurrencyInfoInModel
{
    public string? HasForeignCurrencyIncome { get; set; }      // E01RFI
    public string? ForeignCurrencyIncomeSource { get; set; }   // E01RIS
    public string? ForeignCurrencyDestination { get; set; }    // E01RFD
}
