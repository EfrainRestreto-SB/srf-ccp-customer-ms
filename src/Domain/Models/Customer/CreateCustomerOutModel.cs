namespace Domain.Models.Customer.Out
{
    public class CreateCustomerOutModel
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
        public string IsPEP { get; set; }
        public string ManagesPublicMoney { get; set; }
        public string HasPublicRecognition { get; set; }
        public string StatusCustomer { get; set; }
        public string HasTaxExemptions { get; set; }
        public string IsTaxWithHolder { get; set; }
        public string IsBigTaxpayer { get; set; }
        public string TaxpayerType { get; set; }
        public string SpecialTaxConditions { get; set; }
    }
}
