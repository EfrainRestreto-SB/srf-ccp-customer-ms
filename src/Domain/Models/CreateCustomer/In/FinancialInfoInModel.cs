namespace Domain.Models.CreateCustomer.In;

public class FinancialInfoInModel
{
    public string? OtherIncome { get; set; }              // E01AIC
    public string? FamilyIncome { get; set; }             // E01AIF
    public string? AssetsValue { get; set; }              // E01AVV
    public string? LiabilitiesValue { get; set; }         // E01LAV
    public string? MonthlyExpenses { get; set; }          // E01MOE
    public string? TotalIncome { get; set; }              // E01TIN
    public string? TotalExpenses { get; set; }            // E01TOE
    public string? ActivityType { get; set; }             // E01ACT
    public string? FundOriginCode { get; set; }           // E01FOC
    public string? FundOriginDescription { get; set; }    // E01FOD
}
