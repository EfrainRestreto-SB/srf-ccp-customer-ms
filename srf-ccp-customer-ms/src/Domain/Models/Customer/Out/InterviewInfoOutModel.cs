using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Customer.Out
{
    public class InterviewInfoOutModel
    {
        public string InterviewerName { get; set; }
        public string InterviewerId { get; set; }
        public string InterviewerIdType { get; set; }
        public string InterviewerIdCountry { get; set; }

        public int? InterviewMonth { get; set; }
        public int? InterviewDay { get; set; }
        public int? InterviewYear { get; set; }

        public string CustomerKnowledgeReport { get; set; }
        public string InterviewResult { get; set; }
        public string MasterClientCode { get; set; }
    }

}
