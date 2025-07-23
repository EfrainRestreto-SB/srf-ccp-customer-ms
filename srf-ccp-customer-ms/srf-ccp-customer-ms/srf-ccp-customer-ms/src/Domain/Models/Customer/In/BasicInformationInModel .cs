namespace Domain.Models.CreateCustomer.In;

public class BasicInformationInModel
{
    public string? FirstName { get; set; } // E01FNA - max 40
    public string? SecondName { get; set; } // E01FN2 - max 40
    public string? FirstLastName { get; set; } // E01LN1 - max 40
    public string? SecondLastName { get; set; } // E01LN2 - max 40
    public string? LegalName { get; set; } // E01NM6 - max 160
    public string? Gender { get; set; } // E01SEX - max 1 - valores válidos: F, M
    public string? ClientType { get; set; } // E01TYP - max 1 - valores válidos: R, M, G
    public string? MaritalStatus { get; set; } // E01MST - max 1 - valores válidos: 1,2,3,4,5
    public string? Language { get; set; } // E01LIF - max 1
    public int? ConsultationLevel { get; set; } // E01ILV - numérico max 1
    public string? RiskLevelCode { get; set; } // E01RSL - max 4
    public string? EconomicSector { get; set; } // E01INC - max 4
    public string? EconomicActivity { get; set; } // E01BUC - max 4
    public string? Stratum { get; set; } // E01INL - max 1 - valores válidos: 1-6
    public string? EducationLevel { get; set; } // E01EDL - max 4
    public string? NichoCode { get; set; } // E01CCL - max 1
    public string? IsPEP { get; set; } // E01PEP - max 1 - valores válidos: Y, N
    public string? ManagesPublicMoney { get; set; } // E01MRP - max 1 - valores válidos: Y, N
    public string? HasPublicRecognition { get; set; } // E01RCP - max 1 - valores válidos: Y, N
    public string? Status { get; set; } // E01STS - max 1
    public string? HasTaxExemptions { get; set; } // E01TAX - max 1 - valores válidos: Y, N
    public string? IsTaxWithHolder { get; set; } // E01TX1 - max 1 - valores válidos: Y, N
    public string? IsBigTaxpayer { get; set; } // E01TX2 - max 1 - valores válidos: Y, N
    public string? TaxpayerType { get; set; } // E01TX3 - max 1 - valores válidos: R, N
    public string? SpecialTaxConditions { get; set; } // Campo faltante en comentario, max 1
}
