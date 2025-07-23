using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Customer.Out
{
    public class ReferenceOutModel
    {
        public string ReferenceType { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string FirstLastName { get; set; }
        public string SecondLastName { get; set; }
        public string CountryCode { get; set; }
        public string DepartmentCode { get; set; }
        public string CityCode { get; set; }
        public string LandlinePhone { get; set; }
        public string MobilePhone { get; set; }
        public string PhoneExtension { get; set; }
        public string Relationship { get; set; }
    }
}
