using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.In
{
    public class IdentificationDto
    {
        public string DocumentType { get; set; }
        public string Identity { get; set; }
        public string ExpeditionDate { get; set; }
        public string ExpeditionPlace { get; set; }
        public string IdentificationCountry { get; set; }
        public string IdentificationDepartment { get; set; }
        public string IdentificationMunicipality { get; set; }
        public string ExpeditionState { get; set; }
        public string ExpeditionCity { get; set; }
    }
}
