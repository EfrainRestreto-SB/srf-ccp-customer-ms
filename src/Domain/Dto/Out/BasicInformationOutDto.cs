using System.Text.Json.Serialization;

public class BasicInformationOutDto
{
    [JsonPropertyName("firstName")]
    public string FirstName { get; set; } // E01FNA - max 40 - alfanumérico

    [JsonPropertyName("secondName")]
    public string SecondName { get; set; } // E01FN2 - max 40 - alfanumérico

    [JsonPropertyName("firstLastName")]
    public string FirstLastName { get; set; } // E01LN1 - max 40 - alfanumérico

    [JsonPropertyName("secondLastName")]
    public string SecondLastName { get; set; } // E01LN2 - max 40 - alfanumérico

    [JsonPropertyName("legalName")]
    public string LegalName { get; set; } // E01NM6 - max 160 - alfanumérico

    [JsonPropertyName("gender")]
    public string Gender { get; set; } // E01SEX - max 1 - alfanumérico (F=Femenino, M=Masculino)

    [JsonPropertyName("clientType")]
    public string ClientType { get; set; } // E01TYP - max 1 - alfanumérico (R=Regular, M=Master, G=Grupo)

    [JsonPropertyName("maritalStatus")]
    public string MaritalStatus { get; set; } // E01MST - max 1 - alfanumérico (1=Soltero, 2=Casado, 3=Divorciado, 4=Viudo, 5=Union Libre)

    [JsonPropertyName("language")]
    public string Language { get; set; } // E01LIF - max 1 - alfanumérico

    [JsonPropertyName("consultationLevel")]
    public int ConsultationLevel { get; set; } // E01ILV - max 1 - numérico

    [JsonPropertyName("riskLevelCode")]
    public string RiskLevelCode { get; set; } // E01RSL - max 4 - alfanumérico

    [JsonPropertyName("economicSector")]
    public string EconomicSector { get; set; } // E01INC - max 4 - alfanumérico

    [JsonPropertyName("economicActivity")]
    public string EconomicActivity { get; set; } // E01BUC - max 4 - alfanumérico (CIIU)

    [JsonPropertyName("stratum")]
    public string Stratum { get; set; } // E01INL - max 1 - alfanumérico (1-6)

    [JsonPropertyName("educationLevel")]
    public string EducationLevel { get; set; } // E01EDL - max 4 - alfanumérico

    [JsonPropertyName("nichoCode")]
    public string NichoCode { get; set; } // E01CCL - max 1 - alfanumérico

    [JsonPropertyName("isPEP")]
    public string IsPEP { get; set; } // E01PEP - max 1 - alfanumérico (Y/N)

    [JsonPropertyName("managesPublicMoney")]
    public string ManagesPublicMoney { get; set; } // E01MRP - max 1 - alfanumérico (Y/N)

    [JsonPropertyName("hasPublicRecognition")]
    public string HasPublicRecognition { get; set; } // E01RCP - max 1 - alfanumérico (Y/N)

    [JsonPropertyName("status")]
    public string Status { get; set; } // E01STS - max 1 - alfanumérico

    [JsonPropertyName("hasTaxExemptions")]
    public string HasTaxExemptions { get; set; } // E01TAX - max 1 - alfanumérico (Y/N)

    [JsonPropertyName("isTaxWithHolder")]
    public string IsTaxWithHolder { get; set; } // E01TX1 - max 1 - alfanumérico (Y/N)

    [JsonPropertyName("isBigTaxpayer")]
    public string IsBigTaxpayer { get; set; } // E01TX2 - max 1 - alfanumérico (Y/N)

    [JsonPropertyName("taxpayerType")]
    public string TaxpayerType { get; set; } // E01TX3 - max 1 - alfanumérico (R/N)

    [JsonPropertyName("specialTaxConditions")]
    public string SpecialTaxConditions { get; set; } // E01TX6 - max 1 - alfanumérico (Y/N)
}
