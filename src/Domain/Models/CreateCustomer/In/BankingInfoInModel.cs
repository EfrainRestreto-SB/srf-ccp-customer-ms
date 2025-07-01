namespace Domain.Models.CreateCustomer.In;

public class BankingInfoInModel
{
    public string? TransactionType { get; set; }          // E01TYP
    public string? CompanyNit { get; set; }               // E01NIT
    public string? FirstLastName { get; set; }            // E01LN1
    public string? SecondLastName { get; set; }           // E01LN2
    public string? CountryCode { get; set; }              // E01CTY
    public string? DepartmentCode { get; set; }           // E01DPT
    public string? CityCode { get; set; }                 // E01CDE
    public string? PhoneNumber { get; set; }              // E01PHN
    public string? PhoneExtension { get; set; }           // E01EXT
}
