using System.Text.Json.Serialization;

namespace Domain.Dto.In
{
    public class IdentificationOutDto
    {
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
