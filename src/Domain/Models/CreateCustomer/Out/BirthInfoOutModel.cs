namespace Domain.Models.CreateCustomer.Out;

public class BirthInfoOutModel
{
    public string? BirthDate { get; set; }             // E01BIR (yyyyMMdd)
    public string? BirthCountry { get; set; }          // E01BCY
    public string? BirthDepartment { get; set; }       // E01BDP
    public string? BirthCity { get; set; }             // E01BCT
}
