namespace Domain.Models.CreateCustomer.In;

public class BasicInformationInModel
{
    public string? FirstName { get; set; }                 // E01FNA
    public string? SecondName { get; set; }                // E01FN2
    public string? FirstLastName { get; set; }             // E01LN1
    public string? SecondLastName { get; set; }            // E01LN2
    public string? LegalName { get; set; }                 // E01NM6
    public string? Gender { get; set; }                    // E01SEX
    public string? ClientType { get; set; }                // E01TYP
    public string? MaritalStatus { get; set; }             // E01MST
    public string? Language { get; set; }                  // E01LIV
    public string? ConsultationLevel { get; set; }         // E01LLV
    public string? RiskLevelCode { get; set; }             // E01RSC
    public string? EconomicSector { get; set; }            // E01INC
    public string? EconomicActivity { get; set; }          // E01BUC
    public string? EducationLevel { get; set; }            // E01EDL
    public string? NicheCode { get; set; }                 // E02NCH
    public string? IsPEP { get; set; }                     // E01PEP
    public string? ManagesPublicMoney { get; set; }        // E01MRP
    public string? HasPublicReception { get; set; }        // E01RCP
    public string? Status { get; set; }                    // E01STS
    public string? HasTaxExemptions { get; set; }          // E01TAX
    public string? HasTaxWithholdHolder { get; set; }      // E01TX1
    public string? IsBigTaxpayer { get; set; }             // E01TX2
    public string? TaxpayerType { get; set; }              // E01TX3
    public string? SpecialTaxConditions { get; set; }      // E01TX6
}
