using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In
{
    public class InterviewInfoInDto
    {
        public object FullNameInterviewer;
        public object FullIdInterviewer;
        public object InterviewDate;
        public object InterviewPlace;
        public object InterviewCountry;
        public object InterviewDepartment;
        public object InterviewCity;
        public object InterviewResultCode;

        [JsonPropertyName("interviewerName")]
        public string InterviewerName { get; set; }            // E01CNM

        [JsonPropertyName("interviewerId")]
        public string InterviewerId { get; set; }              // E01ID4

        [JsonPropertyName("interviewerIdType")]
        public string InterviewerIdType { get; set; }          // E01TI4

        [JsonPropertyName("interviewerIdCountry")]
        public string InterviewerIdCountry { get; set; }       // E01PI4

        [JsonPropertyName("interviewMonth")]
        public string InterviewMonth { get; set; }             // E01A1M

        [JsonPropertyName("interviewDay")]
        public string InterviewDay { get; set; }               // E01A1D

        [JsonPropertyName("interviewYear")]
        public string InterviewYear { get; set; }              // E01A1Y

        [JsonPropertyName("customerKnowledgeReport")]
        public string CustomerKnowledgeReport { get; set; }    // E01ICC

        [JsonPropertyName("interviewResult")]
        public string InterviewResult { get; set; }            // E01REN

        [JsonPropertyName("masterClientCode")]
        public string MasterClientCode { get; set; }           // E01GRP
    }
}
