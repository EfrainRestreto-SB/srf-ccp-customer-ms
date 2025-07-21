using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Customer.Out
{
    public class ForeignCurrencyInfoOutModel
    {

        public bool ForeignTransactions { get; set; }
        public bool ForeignProducts { get; set; }

        public decimal? Transaction1Amount { get; set; }
        public string Transaction1Type { get; set; }

        public decimal? Transaction2Amount { get; set; }
        public string Transaction2Type { get; set; }

        public decimal? Transaction3Amount { get; set; }
        public string Transaction3Type { get; set; }

        public string ForeignBank1Name { get; set; }
        public string ForeignBank1Product { get; set; }
        public string ForeignBank1Currency { get; set; }
        public string ForeignBank1Account { get; set; }
        public decimal? ForeignBank1Balance { get; set; }
        public string ForeignBank1Country { get; set; }
        public string ForeignBank1City { get; set; }

        public bool IsForexMarketIntermediary { get; set; }
    }
}
