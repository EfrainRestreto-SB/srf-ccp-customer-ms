using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Customer.Out
{
    public class BankingInfoOutModel
    {
        public int? AffiliationDay { get; set; }
        public int? AffiliationMonth { get; set; }
        public int? AffiliationYear { get; set; }

        public string AffiliationOfficeCode { get; set; }
        public string AffiliationChannel { get; set; }

        public bool StatementDelivery { get; set; }
        public bool ElectronicOperations { get; set; }

        public string CommercialOfficerCode { get; set; }
        public string SecondaryOfficerCode { get; set; }

        public string EntityToAffiliateCode { get; set; }
        public string SuperEntityType { get; set; }
        public string LegalNature { get; set; }
        public string BusinessType { get; set; }
        public string SegmentCode { get; set; }
        public string SuperEntityCode { get; set; }
        public string AddressTypeCode { get; set; }
        public string UndergraduateDegree { get; set; }

        public string InterviewType { get; set; }
        public string BankRelation { get; set; }
        public string ServiceType { get; set; }
        public decimal? RiskPercentage { get; set; }


    }
}
