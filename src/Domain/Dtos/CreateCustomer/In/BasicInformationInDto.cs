using System.Text.Json.Serialization;

namespace Domain.Dtos.CreateCustomer.In;

public class BasicInformationInModel
{
    [JsonPropertyName("firstName")]
    public string? FirstName { get; set; }

    [JsonPropertyName("secondName")]
    public string? SecondName { get; set; }

    [JsonPropertyName("firstLastName")]
    public string? FirstLastName { get; set; }

    [JsonPropertyName("secondLastName")]
    public string? SecondLastName { get; set; }

    [JsonPropertyName("legalName")]
    public string? LegalName { get; set; }

    [JsonPropertyName("gender")]
    public string? Gender { get; set; }

    [JsonPropertyName("clientType")]
    public string? ClientType { get; set; }

    [JsonPropertyName("maritalStatus")]
    public string? MaritalStatus { get; set; }

    [JsonPropertyName("language")]
    public string? Language { get; set; }

    [JsonPropertyName("consultationLevel")]
    public string? ConsultationLevel { get; set; }

    [JsonPropertyName("riskLevelCode")]
    public string? RiskLevelCode { get; set; }

    [JsonPropertyName("economicSector")]
    public string? EconomicSector { get; set; }

    [JsonPropertyName("economicActivity")]
    public string? EconomicActivity { get; set; }

    [JsonPropertyName("educationLevel")]
    public string? EducationLevel { get; set; }

    [JsonPropertyName("nicheCode")]
    public string? NicheCode { get; set; }

    [JsonPropertyName("isPEP")]
    public string? IsPEP { get; set; }

    [JsonPropertyName("managesPublicMoney")]
    public string? ManagesPublicMoney { get; set; }

    [JsonPropertyName("hasPublicReception")]
    public string? HasPublicReception { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("hasTaxExemptions")]
    public string? HasTaxExemptions { get; set; }

    [JsonPropertyName("hasTaxWithholdHolder")]
    public string? HasTaxWithholdHolder { get; set; }

    [JsonPropertyName("isBigTaxpayer")]
    public string? IsBigTaxpayer { get; set; }

    [JsonPropertyName("taxpayerType")]
    public string? TaxpayerType { get; set; }

    [JsonPropertyName("specialTaxConditions")]
    public string? SpecialTaxConditions { get; set; }
}
