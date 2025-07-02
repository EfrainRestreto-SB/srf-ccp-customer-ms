using System.Text.Json.Serialization;

public class BankingInfoOutDto
{
    [JsonPropertyName("affiliationMonth")]
    public int? AffiliationMonth { get; set; }

    [JsonPropertyName("affiliationDay")]
    public int? AffiliationDay { get; set; }

    [JsonPropertyName("affiliationYears")]
    public int? AffiliationYears { get; set; }

    [JsonPropertyName("affiliationOfficeCode")]
    public string? AffiliationOfficeCode { get; set; }

    [JsonPropertyName("affiliationChannel")]
    public string? AffiliationChannel { get; set; }

    [JsonPropertyName("statementDelivery")]
    public string? StatementDelivery { get; set; }

    [JsonPropertyName("electronicOperations")]
    public string? ElectronicOperations { get; set; }

    [JsonPropertyName("commercialOfficerCode")]
    public string? CommercialOfficerCode { get; set; }

    [JsonPropertyName("secondaryOfficerCode")]
    public string? SecondaryOfficerCode { get; set; }

    [JsonPropertyName("entityToAffiliateCode")]
    public string? EntityToAffiliateCode { get; set; }

    [JsonPropertyName("superEntityType")]
    public string? SuperEntityType { get; set; }

    [JsonPropertyName("legalNature")]
    public string? LegalNature { get; set; }

    [JsonPropertyName("businessType")]
    public string? BusinessType { get; set; }

    [JsonPropertyName("segmentCode")]
    public string? SegmentCode { get; set; }

    [JsonPropertyName("superEntityCode")]
    public string? SuperEntityCode { get; set; }

    [JsonPropertyName("addressType")]
    public string? AddressType { get; set; }

    [JsonPropertyName("underGraduateDegree")]
    public string? UnderGraduateDegree { get; set; }

    [JsonPropertyName("interviewType")]
    public string? InterviewType { get; set; }

    [JsonPropertyName("bankRelation")]
    public string? BankRelation { get; set; }

    [JsonPropertyName("servicesType")]
    public string? ServicesType { get; set; }

    [JsonPropertyName("riskPercentage")]
    public string? RiskPercentage { get; set; }
}
