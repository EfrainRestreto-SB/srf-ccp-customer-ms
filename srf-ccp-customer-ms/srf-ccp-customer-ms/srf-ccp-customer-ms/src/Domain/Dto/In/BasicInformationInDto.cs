using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In;

public class BasicInformationInDto
{
    [JsonPropertyName("firstName")]
    public required string FirstName { get; set; }

    [JsonPropertyName("secondName")]
    public required string SecondName { get; set; }

    [JsonPropertyName("firstLastName")]
    public required string FirstLastName { get; set; }

    [JsonPropertyName("secondLastName")]
    public required string SecondLastName { get; set; }

    [JsonPropertyName("legalName")]
    public required string LegalName { get; set; }

    [JsonPropertyName("gender")]
    public required string Gender { get; set; }

    [JsonPropertyName("clientType")]
    public required string ClientType { get; set; }

    [JsonPropertyName("maritalStatus")]
    public required string MaritalStatus { get; set; }

    [JsonPropertyName("language")]
    public required string Language { get; set; }

    [JsonPropertyName("consultationLevel")]
    public int? ConsultationLevel { get; set; }

    [JsonPropertyName("riskLevelCode")]
    public required string RiskLevelCode { get; set; }

    [JsonPropertyName("economicSector")]
    public required string EconomicSector { get; set; }

    [JsonPropertyName("economicActivity")]
    public required string EconomicActivity { get; set; }

    [JsonPropertyName("stratum")]
    public required string Stratum { get; set; }

    [JsonPropertyName("educationLevel")]
    public required string EducationLevel { get; set; }

    [JsonPropertyName("nichoCode")]
    public required string NichoCode { get; set; }

    [JsonPropertyName("isPEP")]
    public required string IsPEP { get; set; }

    [JsonPropertyName("managesPublicMoney")]
    public required string ManagesPublicMoney { get; set; }

    [JsonPropertyName("hasPublicRecognition")]
    public required string HasPublicRecognition { get; set; }

    [JsonPropertyName("status")]
    public required string Status { get; set; }

    [JsonPropertyName("hasTaxExemptions")]
    public required string HasTaxExemptions { get; set; }

    [JsonPropertyName("isTaxWithHolder")]
    public required string IsTaxWithHolder { get; set; }

    [JsonPropertyName("isBigTaxpayer")]
    public required string IsBigTaxpayer { get; set; }

    [JsonPropertyName("taxpayerType")]
    public required string TaxpayerType { get; set; }

    [JsonPropertyName("specialTaxConditions")]
    public required string SpecialTaxConditions { get; set; }
}
