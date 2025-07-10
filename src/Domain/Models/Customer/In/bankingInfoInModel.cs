using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Customer.In
{
    internal class bankingInfoInModel
    {
        public required string affiliationMonth { get; set; }
        public required string affiliationDay { get; set; } 
        public required string affiliationYear { get; set; }
        public required string affiliationOfficeCode { get; set; }

        public required string affiliationChannel { get; set; }
        public required string statementDelivery { get; set; }

        public required string electronicOperations { get; set; }
        public required string commercialOfficerCode { get; set; }
        public required string secondaryOfficerCode { get; set; }
        public required string entityToAffiliateCode { get; set; }

        public required string superEntityType { get; set; }
        public required string legalNature { get; set; }
        public required string businessType { get; set; }

        public required string segmentCode { get; set; }

        public required string superEntityCode { get; set; }
        public required string addressTypeCode { get; set; }
        public required string undergraduateDegree { get; set; }
        public required string interviewType { get; set; }
        public required string bankRelation { get; set; }
        public required string serviceType { get; set; }
        public required string riskPercentage { get; set; }







    }
}
