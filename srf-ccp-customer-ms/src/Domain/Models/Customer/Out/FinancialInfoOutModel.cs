using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Customer.Out
{
    public class FinancialInfoOutModel
    {
        public decimal? MonthlyIncome { get; set; }
        public decimal? OtherIncome { get; set; }
        public decimal? FamilyExpenses { get; set; }
        public decimal? TotalLiabilities { get; set; }
        public decimal? OtherAssets { get; set; }
        public decimal? RealStateAssets { get; set; }
        public decimal? TotalAssets { get; set; }
        public decimal? TotalIncome { get; set; }
        public decimal? TotalExpenses { get; set; }

        public string FundsOriginDescription1 { get; set; }
        public string FundsOriginDescription2 { get; set; }
        public string FundsOriginDescription3 { get; set; }
    }
}
