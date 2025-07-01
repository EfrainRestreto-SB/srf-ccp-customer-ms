using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Dtos.CreateCustomer.Out
{
    public class InterviewInfoDto
    {
        [JsonPropertyName("interviewName")]
        public string? interviewName { get; set; }

        [JsonPropertyName("intervieId")]
        public string? interviewId { get; set; }

        [JsonPropertyName("interviewIdType")]
        public string? interviewIdType { get; set; }

        [JsonPropertyName("interviewIdCountry")]
        public string? interviewIdCountry { get; set; }

        [JsonPropertyName("interviewMonth")]
        public string? interviewMonth { get; set; }

        [JsonPropertyName("interviewYear")]
        public string? interviewYear { get; set; }

        [JsonPropertyName("customerKnowledgeReport")]
        public string? customerKnowledgeReport { get; set; }

        [JsonPropertyName("interviewResult")]
        public string? interviewResult { get; set; }

        [JsonPropertyName("masterClientCode")]
        public string? masterClientCode { get; set; }


    }
}
