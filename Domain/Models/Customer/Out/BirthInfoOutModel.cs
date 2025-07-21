using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Customer.Out
{
    public class BirthInfoOutModel
    {
        public int? BirthDay { get; set; }
        public int? BirthMonth { get; set; }
        public int? BirthYear { get; set; }
        public string BirthCountry { get; set; }
        public string BirthDepartment { get; set; }
        public string BirthCity { get; set; }
    }
}
