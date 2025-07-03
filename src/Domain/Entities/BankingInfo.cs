namespace Domain.Entities.Customer;

public class BankingInfo
{
    public string BankName { get; set; } = default!;
    public string AccountType { get; set; } = default!;
    public string AccountNumber { get; set; } = default!;
}
