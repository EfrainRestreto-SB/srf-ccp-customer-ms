namespace Domain.Models.Customer
{
    public class InterviewInfoInModel
    {
        public string InterviewerName { get; set; }                    // Máx 45
        public string InterviewerId { get; set; }                      // Máx 25
        public string InterviewerIdType { get; set; }                  // Máx 4
        public string InterviewerIdCountry { get; set; }              // Máx 4
        public int InterviewMonth { get; set; }                        // Máx 2 dígitos
        public int InterviewDay { get; set; }                          // Máx 2 dígitos
        public int InterviewYear { get; set; }                         // Máx 4 dígitos
        public string CustomerKnowledgeReport { get; set; }           // Máx 300
        public string InterviewResult { get; set; }                   // Máx 300
        public long MasterClientCode { get; set; }                    // Máx 9
    }
}
