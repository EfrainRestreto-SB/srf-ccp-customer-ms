using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.In
{
    public class IdentificationDto
    {
        public required object DocumentType;
        public required object ExpeditionDate;
        public required object IdentificationCountry;

        public required string idNumber { get; set; }
        public required string idType { get; set; }
        public required string idCountry { get; set; }
        public required string idIssuePlace { get; set; }
        public required string idIssueMonth { get; set; }
        public required string idIssueDay { get; set; }
        public required string idIssueYear { get; set; }
        public required string nationalityCode { get; set; }
        public required string fiscalEmployeeId { get; set; }
    }
}
