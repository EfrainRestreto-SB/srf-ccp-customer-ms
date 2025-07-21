using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Customer.Out
{
    public class IdentificationOutModel
    {
        public string IdNumber { get; set; }
        public string IdType { get; set; }
        public string IdCountry { get; set; }
        public string IdIssuePlace { get; set; }

        public int? IdIssueDay { get; set; }
        public int? IdIssueMonth { get; set; }
        public int? IdIssueYear { get; set; }

        public string NationalityCode { get; set; }
        public string FiscalEmployeeId { get; set; }
    }
}
