using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In;

public class BasicInformationInDto
{
    [JsonPropertyName("firstName")]
    public string FirstName { get; set; }

    [JsonPropertyName("secondName")]
    public string SecondName { get; set; }

    [JsonPropertyName("firstLastName")]
    public string FirstLastName { get; set; }

    [JsonPropertyName("secondLastName")]
    public string SecondLastName { get; set; }

    [JsonPropertyName("legalName")]
    public string LegalName { get; set; }

    [JsonPropertyName("gender")]
    public string Gender { get; set; }

    [JsonPropertyName("clientType")]
    public string ClientType { get; set; }

    [JsonPropertyName("maritalStatus")]
    public string MaritalStatus { get; set; }

    [JsonPropertyName("language")]
    public string Language { get; set; }

    [JsonPropertyName("consultationLevel")]
    public int? ConsultationLevel { get; set; }

    [JsonPropertyName("riskLevelCode")]
    public string RiskLevelCode { get; set; }

    [JsonPropertyName("economicSector")]
    public string EconomicSector { get; set; }

    [JsonPropertyName("economicActivity")]
    public string EconomicActivity { get; set; }

    [JsonPropertyName("stratum")]
    public string Stratum { get; set; }

    [JsonPropertyName("educationLevel")]
    public string EducationLevel { get; set; }

    [JsonPropertyName("nichoCode")]
    public string NichoCode { get; set; }

    [JsonPropertyName("isPEP")]
    public string IsPEP { get; set; }

    [JsonPropertyName("managesPublicMoney")]
    public string ManagesPublicMoney { get; set; }

    [JsonPropertyName("hasPublicRecognition")]
    public string HasPublicRecognition { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("hasTaxExemptions")]
    public string HasTaxExemptions { get; set; }

    [JsonPropertyName("isTaxWithHolder")]
    public string IsTaxWithHolder { get; set; }

    [JsonPropertyName("isBigTaxpayer")]
    public string IsBigTaxpayer { get; set; }

    [JsonPropertyName("taxpayerType")]
    public string TaxpayerType { get; set; }

    [JsonPropertyName("specialTaxConditions")]
    public string SpecialTaxConditions { get; set; }
}
