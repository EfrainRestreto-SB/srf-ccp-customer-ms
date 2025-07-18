using System.Text.Json.Serialization;

public class BankingInfoOutDto
{
    [JsonPropertyName("affiliationMonth")]
    public int AffiliationMonth { get; set; } // E01IDM - max-length 2 - numérico - Uso exclusivo banco

    [JsonPropertyName("affiliationDay")]
    public int AffiliationDay { get; set; } // E01IDD - max-length 2 - numérico - Uso exclusivo banco

    [JsonPropertyName("affiliationYear")]
    public int AffiliationYear { get; set; } // E01IDY - max-length 4 - numérico - Uso exclusivo banco

    [JsonPropertyName("affiliationOfficeCode")]
    public string AffiliationOfficeCode { get; set; } // E01BRA - max-length 4 - numérico - Maestro Oficinas IBS

    [JsonPropertyName("affiliationChannel")]
    public string AffiliationChannel { get; set; } // E01RBY - max-length 4 - alfanumérico

    [JsonPropertyName("statementDelivery")]
    public string StatementDelivery { get; set; } // E01FL5 - max-length 1 - alfanumérico - R=Residencia, O=Oficina, C=Correo

    [JsonPropertyName("electronicOperations")]
    public string ElectronicOperations { get; set; } // E01FL8 - max-length 8 - alfanumérico

    [JsonPropertyName("commercialOfficerCode")]
    public string CommercialOfficerCode { get; set; } // E01OFC - max-length 4 - alfanumérico - Uso exclusivo banco

    [JsonPropertyName("secondaryOfficerCode")]
    public string SecondaryOfficerCode { get; set; } // E01OF2 - max-length 4 - alfanumérico

    [JsonPropertyName("entityToAffiliateCode")]
    public string EntityToAffiliateCode { get; set; } // E01UC1 - max-length 4 - alfanumérico

    [JsonPropertyName("superEntityType")]
    public string SuperEntityType { get; set; } // E01UC2 - max-length 4 - alfanumérico

    [JsonPropertyName("legalNature")]
    public string LegalNature { get; set; } // E01UC3 - max-length 4 - alfanumérico

    [JsonPropertyName("businessType")]
    public string BusinessType { get; set; } // E01UC4 - max-length 4 - alfanumérico

    [JsonPropertyName("segmentCode")]
    public string SegmentCode { get; set; } // E01UC5 - max-length 4 - alfanumérico - Uso exclusivo banco

    [JsonPropertyName("superEntityCode")]
    public string SuperEntityCode { get; set; } // E01UC6 - max-length 4 - alfanumérico

    [JsonPropertyName("addressTypeCode")]
    public string AddressTypeCode { get; set; } // E01UC7 - max-length 4 - alfanumérico

    [JsonPropertyName("undergraduateDegree")]
    public string UndergraduateDegree { get; set; } // E01UC9 - max-length 4 - alfanumérico - Referencias Comunes (Tabla 49)

    [JsonPropertyName("interviewType")]
    public string InterviewType { get; set; } // E01FL3 - max-length 1 - alfanumérico

    [JsonPropertyName("bankRelation")]
    public string BankRelation { get; set; } // E01STF - max-length 1 - alfanumérico

    [JsonPropertyName("serviceType")]
    public string ServiceType { get; set; } // E01TSE - max-length 4 - alfanumérico - Referencias Comunes (Tabla TC)

    [JsonPropertyName("riskPercentage")]
    public decimal RiskPercentage { get; set; } // E01PPA - max-length 6 - numérico (decimal)
}
