namespace Domain.Models.CreateCustomer.Out;

public class FinancialInfoOutModel
{
    public string? OtherIncome { get; set; }
    public string? FamilyIncome { get; set; }
    public string? AssetsValue { get; set; }
    public string? LiabilitiesValue { get; set; }
    public string? MonthlyExpenses { get; set; }
    public string? TotalIncome { get; set; }
    public string? TotalExpenses { get; set; }
    public string? ActivityType { get; set; }
    public string? FundOriginCode { get; set; }
    public string? FundOriginDescription { get; set; }
}
