using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Customer.Out
{
    public class EmploymentInfoOutModel
    {
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string JobPosition { get; set; }
        public string PreviousCompany { get; set; }

        public int? EmploymentStartDay { get; set; }
        public int? EmploymentStartMonth { get; set; }
        public int? EmploymentStartYear { get; set; }

        public string CompanyCityCode { get; set; }
        public string CompanyCountry { get; set; }
        public string ContractType { get; set; }
        public string DepartmentCode { get; set; }
        public string WorkPhone { get; set; }
        public string WorkExtension { get; set; }

        public int? PreviousJobYears { get; set; }
        public int? PreviousJobMonths { get; set; }
        public int? EmployeesCount { get; set; }
        public string OccupationCode { get; set; }
        public int? DependentsCount { get; set; }
    }
}
