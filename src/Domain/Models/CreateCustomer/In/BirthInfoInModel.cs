namespace Domain.Models.CreateCustomer.In;

public class BirthInfoInModel
{
    public string? BirthCountry { get; set; }       // E01BCY
    public string? BirthDepartment { get; set; }    // E01BDP
    public string? BirthCity { get; set; }          // E01BCT
    public string? BirthDate { get; set; }          // E01DOB (formato: yyyyMMdd)
}
