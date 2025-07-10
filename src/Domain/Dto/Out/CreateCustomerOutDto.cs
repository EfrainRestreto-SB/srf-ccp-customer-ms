namespace Domain.Dtos.Customer.Out
{
    public class CreateCustomerOutDto
    {
        public required string FirstName { get; set; }
        public required string SecondName { get; set; }
        public required string FirstLastName { get; set; }
        public required string SecondLastName { get; set; }
        public required string LegalName { get; set; }
        public required string Gender { get; set; }
        public required string ClientType { get; set; }
        public required string MaritalStatus { get; set; }
        public required string Language { get; set; }
        public required string ConsultationLevel { get; set; }
        public required string RiskLevelCode { get; set; }
        public required string EconomicSector { get; set; }
        public required string EconomicActivity { get; set; }
        public required string Stratum { get; set; }
        public required string EducationLevel { get; set; }
        public required string NichoCode { get; set; }
        public required string IsPEP { get; set; }
        public required string ManagesPublicMoney { get; set; }
        public required string HasPublicRecognition { get; set; }
        public required string StatusCustomer { get; set; }
        public required string HasTaxExemptions { get; set; }
        public required string IsTaxWithHolder { get; set; }
        public required string IsBigTaxpayer { get; set; }
        public required string TaxpayerType { get; set; }
        public required string SpecialTaxConditions { get; set; }
    }
}
