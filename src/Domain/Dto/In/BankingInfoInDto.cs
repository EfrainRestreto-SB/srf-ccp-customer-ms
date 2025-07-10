using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In
{
    public class BankingInfoInDto
    {
        [JsonPropertyName("affiliationMonth")]
        public required string AffiliationMonth { get; set; }        // E01IDM

        [JsonPropertyName("affiliationDay")]
        public required string AffiliationDay { get; set; }          // E01IDD

        [JsonPropertyName("affiliationYear")]
        public required string AffiliationYear { get; set; }         // E01IDY

        [JsonPropertyName("affiliationOfficeCode")]
        public required string AffiliationOfficeCode { get; set; }   // E01BRA

        [JsonPropertyName("affiliationChannel")]
        public required string AffiliationChannel { get; set; }      // E01RBY

        [JsonPropertyName("statementDelivery")]
        public required string StatementDelivery { get; set; }       // E01FL5

        [JsonPropertyName("electronicOperations")]
        public required string ElectronicOperations { get; set; }   // E01FL8

        [JsonPropertyName("commercialOfficerCode")]
        public required string CommercialOfficerCode { get; set; }   // E01OFC

        [JsonPropertyName("secondaryOfficerCode")]
        public required string SecondaryOfficerCode { get; set; }    // E01OF2

        [JsonPropertyName("entityToAffiliateCode")]
        public required string EntityToAffiliateCode { get; set; }   // E01UC1

        [JsonPropertyName("superEntityType")]
        public required string SuperEntityType { get; set; }         // E01UC2

        [JsonPropertyName("legalNature")]
        public required string LegalNature { get; set; }             // E01UC3

        [JsonPropertyName("businessType")]
        public required string BusinessType { get; set; }            // E01UC4

        [JsonPropertyName("segmentCode")]
        public required string SegmentCode { get; set; }             // E01UC5

        [JsonPropertyName("superEntityCode")]
        public required string SuperEntityCode { get; set; }         // E01UC6

        [JsonPropertyName("addressTypeCode")]
        public required string AddressTypeCode { get; set; }         // E01UC7

        [JsonPropertyName("undergraduateDegree")]
        public required string UndergraduateDegree { get; set; }     // E01UC9

        [JsonPropertyName("interviewType")]
        public required string InterviewType { get; set; }           // E01FL3

        [JsonPropertyName("bankRelation")]
        public required string BankRelation { get; set; }            // E01STF

        [JsonPropertyName("serviceType")]
        public required string ServiceType { get; set; }             // E01TSE

        [JsonPropertyName("riskPercentage")]
        public required string RiskPercentage { get; set; }          // E01PPA
    }
}
