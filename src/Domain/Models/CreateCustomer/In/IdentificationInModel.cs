namespace Domain.Models.CreateCustomer.In;

public class IdentificationInModel
{
    public string? DocumentType { get; set; }              // E01IDT
    public string? DocumentNumber { get; set; }            // E01IDN
    public string? IssuingCountry { get; set; }            // E01ICO
    public string? IssuingDepartment { get; set; }         // E01IDP
    public string? IssuingCity { get; set; }               // E01ICT
    public string? ExpeditionDate { get; set; }            // E01DOE (Formato: yyyyMMdd)
    public string? Nationality { get; set; }               // E01NAT
    public string? ResidencyCountry { get; set; }          // E01RCY
    public string? ResidencyDepartment { get; set; }       // E01RDP
    public string? ResidencyCity { get; set; }             // E01RCT
}
