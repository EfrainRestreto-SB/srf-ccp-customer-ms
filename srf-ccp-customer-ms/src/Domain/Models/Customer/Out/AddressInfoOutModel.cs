using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Customer.Out
{
    public class AddressInfoOutModel
    {

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string CityCode { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string ResidenceCountry { get; set; }
        public int? CurrentResidenceYears { get; set; }
        public int? CurrentResidenceMonths { get; set; }
        public string HousingType { get; set; }
    }
}
