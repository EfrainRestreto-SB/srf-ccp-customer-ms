namespace Domain.Models.CreateCustomer.Out;

public class BankingInfoOutModel
{
    public string? BankName { get; set; }                // E01BNK
    public string? AccountType { get; set; }             // E01TAC
    public string? AccountNumber { get; set; }           // E01ACC
    public string? IsAccountHolder { get; set; }         // E01ACT
}

