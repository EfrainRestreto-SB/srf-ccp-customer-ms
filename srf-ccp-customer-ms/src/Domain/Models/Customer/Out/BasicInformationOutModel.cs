using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Customer.Out
{
    public class BasicInformationOutModel
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstLastName { get; set; }
        public string SecondLastName { get; set; }
        public string LegalName { get; set; }
        public string Gender { get; set; }
        public string ClientType { get; set; }
        public string MaritalStatus { get; set; }
        public string Language { get; set; }
        public string ConsultationLevel { get; set; }
        public string RiskLevelCode { get; set; }
        public string EconomicSector { get; set; }
        public string EconomicActivity { get; set; }
        public string Stratum { get; set; }
        public string EducationLevel { get; set; }
        public string NichoCode { get; set; }
        public bool IsPEP { get; set; }
        public bool ManagesPublicMoney { get; set; }
        public bool HasPublicRecognition { get; set; }
        public string Status { get; set; }
        public bool HasTaxExemptions { get; set; }
        public bool IsTaxWithHolder { get; set; }
        public bool IsBigTaxpayer { get; set; }
        public string TaxpayerType { get; set; }
        public string SpecialTaxConditions { get; set; }
    }
}
