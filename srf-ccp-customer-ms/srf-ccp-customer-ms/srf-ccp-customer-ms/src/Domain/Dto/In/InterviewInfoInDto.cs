using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In;

public class InterviewInfoInDto
{
    [JsonPropertyName("interviewerName")]
    public string InterviewerName { get; set; }

    [JsonPropertyName("interviewerId")]
    public string InterviewerId { get; set; }

    [JsonPropertyName("interviewerIdType")]
    public string InterviewerIdType { get; set; }

    [JsonPropertyName("interviewerIdCountry")]
    public string InterviewerIdCountry { get; set; }

    [JsonPropertyName("interviewMonth")]
    public int InterviewMonth { get; set; }

    [JsonPropertyName("interviewDay")]
    public int InterviewDay { get; set; }

    [JsonPropertyName("interviewYear")]
    public int InterviewYear { get; set; }

    [JsonPropertyName("customerKnowledgeReport")]
    public string CustomerKnowledgeReport { get; set; }

    [JsonPropertyName("interviewResult")]
    public string InterviewResult { get; set; }

    [JsonPropertyName("masterClientCode")]
    public int MasterClientCode { get; set; }
}
