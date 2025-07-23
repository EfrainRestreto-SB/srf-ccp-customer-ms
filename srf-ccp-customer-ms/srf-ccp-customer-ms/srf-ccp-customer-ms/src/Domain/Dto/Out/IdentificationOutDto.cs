using System.Text.Json.Serialization;

namespace Domain.Dto.In
{
    public class IdentificationOutDto
    {
        [JsonPropertyName("idNumber")]
        public required string IdNumber { get; set; }

        [JsonPropertyName("idType")]
        public required string IdType { get; set; }

        [JsonPropertyName("idCountry")]
        public required string IdCountry { get; set; }

        [JsonPropertyName("idIssuePlace")]
        public required string IdIssuePlace { get; set; }

        [JsonPropertyName("idIssueDay")]
        public required int IdIssueDay { get; set; }

        [JsonPropertyName("idIssueMonth")]
        public required int IdIssueMonth { get; set; }

        [JsonPropertyName("idIssueYear")]
        public required int IdIssueYear { get; set; }

        [JsonPropertyName("nationalityCode")]
        public required string NationalityCode { get; set; }

        [JsonPropertyName("fiscalEmployeeId")]
        public required string FiscalEmployeeId { get; set; }
    }
}
