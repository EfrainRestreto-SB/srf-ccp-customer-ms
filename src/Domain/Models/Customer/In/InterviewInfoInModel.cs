namespace Domain.Dto.In
{
    public class InterviewInfoDto
    {
        public required string interviewerName { get; set; }
        public required string interviewerId { get; set; }
        public required string interviewerIdType { get; set; }
        public required string interviewerIdCountry { get; set; }
        public required string interviewMonth { get; set; }
        public required string interviewDay { get; set; }
        public required string interviewYear { get; set; }
        public required string customerKnowledgeReport { get; set; }
        public required string interviewResult { get; set; }

        public required string interviewComments { get; set; }
        public required string masterClientCode { get; set; }
    }
}
