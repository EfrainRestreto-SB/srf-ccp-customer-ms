namespace Domain.Models.CreateCustomer.Out;

public class IdentificationOutModel
{
    public string? DocumentType { get; set; }
    public string? DocumentNumber { get; set; }
    public string? IssuingCountry { get; set; }
    public string? IssuingDepartment { get; set; }
    public string? IssuingCity { get; set; }
    public string? ExpeditionDate { get; set; }
    public string? Nationality { get; set; }
    public string? ResidencyCountry { get; set; }
    public string? ResidencyDepartment { get; set; }
    public string? ResidencyCity { get; set; }
}
