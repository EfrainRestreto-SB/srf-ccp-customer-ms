using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.In
{
    public class BirthInfoInModel
    {
        public required string fiscalEmployeeId { get; set; }
        public required string birthDay { get; set; }
        public required string birthYear { get; set; }
        public required string birthCountry { get; set; }
        public required string birthDepartment { get; set; }

        public required string birthCity { get; set; }
    }
}
