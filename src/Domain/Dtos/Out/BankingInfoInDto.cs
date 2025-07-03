using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Dtos.Out
{
    public class BankingInfoOutDto
    {
        [JsonPropertyName("affiliantionMonth")]
        public string? affiliantionMonth { get; set; }

        [JsonPropertyName("affiliantionDay")]
        public string? affiliantionDay { get; set; }

        [JsonPropertyName("affiliantionYears")]
        public string? affiliantionYears { get; set; }

        [JsonPropertyName("affiliantionOfficeCode")]
        public string? affiliantionOfficeCode { get; set; }

        [JsonPropertyName("affiliantionChannel")]
        public string? affiliantionChannel { get; set; }

        [JsonPropertyName("statementDelivery")]
        public string? statementDelivery { get; set; }

        [JsonPropertyName("electronicOperations")]
        public string? electretonicOperations { get; set; }

        [JsonPropertyName("commercialOfficerCode")]
        public string? commercialOfficerCode { get; set; }

        [JsonPropertyName("secondaryOfficerCode")]
        public string? secondaryOfficerCode { get; set; }

        [JsonPropertyName("entitytoAffiliateCode")]
        public string? entitytoAffiliateCode { get; set; }

        [JsonPropertyName("superEntityType")]
        public string? superEntityType { get; set; }

        [JsonPropertyName("legalNature")]
        public string? LegalNature { get; set; }

        [JsonPropertyName("businessType")]
        public string? businessType { get; set; }

        [JsonPropertyName("segmentCode")]
        public string? segmentCode { get; set; }

        [JsonPropertyName("superEntityCode")]
        public string? superEntityCode { get; set; }

        [JsonPropertyName("adressType")]
        public string? adressType { get; set; }

        [JsonPropertyName("underGraduateDegree")]
        public string?underGraduateDegree { get; set; }

        [JsonPropertyName("interviewType")]
        public string? interviewType { get; set; }

        [JsonPropertyName("banckRelation")]
        public string? banckRelation { get; set; }

        [JsonPropertyName("servicesType")]
        public string? serviicesType { get; set; }

        [JsonPropertyName("riskPercentage")]
        public string? riskPercentage { get; set; }

    }
}
