using System.Text.Json.Serialization;

namespace Domain.Dto.In
{
    public class IdentificationInDto
    {
        public object IdType;
        public object IdNumber;
        public object IssueDate;
        public object IssueCountry;
        public object IssueDepartment;
        public object IssueCity;
        public object Identity;
        public object IdentificationCountry;

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("department")]
        public string Department { get; set; }

        [JsonPropertyName("municipality")]
        public string Municipality { get; set; }

        [JsonPropertyName("documentNumber")]
        public string DocumentNumber { get; set; }

        [JsonPropertyName("documentType")]
        public string DocumentType { get; set; }

        [JsonPropertyName("expeditionDate")]
        public string ExpeditionDate { get; set; }

        [JsonPropertyName("expeditionCountry")]
        public string ExpeditionCountry { get; set; }

        [JsonPropertyName("expeditionDepartment")]
        public string ExpeditionDepartment { get; set; }

        [JsonPropertyName("expeditionCity")]
        public string ExpeditionCity { get; set; }
    }
}
