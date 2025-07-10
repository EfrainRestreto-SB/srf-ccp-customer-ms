using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.In
{
    public class BasicInformationDto
    {
        public required string FirstName { get; set; }
        public required string SecondName { get; set; }
        public required string firstLastName { get; set; }
        public required string secondLastName { get; set; }
        public required string legalName { get; set; }
        public required string gender { get; set; }
        public required string clientType { get; set; }
        public required string maritalStatus { get; set; }
        public required string language { get; set; }
        public required string consultationLevel { get; set; }
        public required string riskLevelCode { get; set; }
        public required string economicSector { get; set; }
        public required string economicActivity { get; set; }
        public required string stratum { get; set; }
        public required string educationLevel { get; set; }
        public required string nichoCode { get; set; }
        public required string isPEP { get; set; }
        public required string managesPublicMoney { get; set; }
        public required string hasPublicRecognition { get; set; }
        public required string status { get; set; }
        public required string hasTaxExemptions { get; set; }

        public required string isTaxWithHolder { get; set; }

        public required string isBigTaxpayer { get; set; }
        public required string taxpayerType { get; set; }
        public required string specialTaxConditions { get; set; }






    }
}

