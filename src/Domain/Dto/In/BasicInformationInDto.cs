using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In
{
    public class BasicInformationInDto
    {
        public required object FirstSurname { get; set; }   // E01LN1
        public required object Genders { get; set; }        // E01SEX
        public required object IdentityStatus { get; set; } // E01STS
        public required object InternalStatus { get; set; } // E01INL
        public required object EducationLevelCode { get; set; } // E01EDL
        public required object EthnicCode { get; set; }     // E01ETH
        public required object Ethnic { get; set; }         // E01ETH
        public required object StatusPeps { get; set; }     // E01PEP

        // Campos que se mapean directamente del JSON con JsonPropertyName
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }               // E01FNA

        [JsonPropertyName("secondName")]
        public string SecondName { get; set; }              // E01FN2

        [JsonPropertyName("firstLastName")]
        public string FirstLastName { get; set; }           // E01LN1

        [JsonPropertyName("secondLastName")]
        public string SecondLastName { get; set; }          // E01LN2

        [JsonPropertyName("legalName")]
        public string LegalName { get; set; }               // E01NM6

        [JsonPropertyName("gender")]
        public string Gender { get; set; }                  // E01SEX

        [JsonPropertyName("clientType")]
        public string ClientType { get; set; }              // E01TYP

        [JsonPropertyName("maritalStatus")]
        public string MaritalStatus { get; set; }           // E01MST

        [JsonPropertyName("language")]
        public string Language { get; set; }                // E01LIF

        [JsonPropertyName("consultationLevel")]
        public string ConsultationLevel { get; set; }       // E01ILV

        [JsonPropertyName("riskLevelCode")]
        public string RiskLevelCode { get; set; }           // E01RSL

        [JsonPropertyName("economicSector")]
        public string EconomicSector { get; set; }          // E01INC

        [JsonPropertyName("economicActivity")]
        public string EconomicActivity { get; set; }        // E01BUC

        [JsonPropertyName("stratum")]
        public string Stratum { get; set; }                 // E01INL

        [JsonPropertyName("educationLevel")]
        public string EducationLevel { get; set; }          // E01EDL

        [JsonPropertyName("nichoCode")]
        public string NichoCode { get; set; }               // E01CCL

        [JsonPropertyName("isPEP")]
        public string IsPEP { get; set; }                   // E01PEP

        [JsonPropertyName("managesPublicMoney")]
        public string ManagesPublicMoney { get; set; }      // E01MRP

        [JsonPropertyName("hasPublicRecognition")]
        public string HasPublicRecognition { get; set; }    // E01RCP

        [JsonPropertyName("status")]
        public string Status { get; set; }                  // E01STS

        [JsonPropertyName("hasTaxExemptions")]
        public string HasTaxExemptions { get; set; }        // E01TAX

        [JsonPropertyName("isTaxWithHolder")]
        public string IsTaxWithHolder { get; set; }         // E01TX1

        [JsonPropertyName("isBigTaxpayer")]
        public string IsBigTaxpayer { get; set; }           // E01TX2

        [JsonPropertyName("taxpayerType")]
        public string TaxpayerType { get; set; }            // E01TX3

        [JsonPropertyName("specialTaxConditions")]
        public string SpecialTaxConditions { get; set; }    // E01TX6
    }
}
