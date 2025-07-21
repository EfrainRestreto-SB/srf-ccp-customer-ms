namespace Domain.Models.Customer
{
    public class BankingInfoInModel
    {
        public int AffiliationMonth { get; set; }               // E01IDM - max 2 dígitos
        public int AffiliationDay { get; set; }                 // E01IDD - max 2 dígitos
        public int AffiliationYear { get; set; }                // E01IDY - max 4 dígitos

        public string AffiliationOfficeCode { get; set; }       // E01BRA - max-length 4, numérico
        public string AffiliationChannel { get; set; }          // E01RBY - max-length 4, alfanumérico
        public string StatementDelivery { get; set; }           // E01FL5 - max-length 1, valores: R, O, C
        public string ElectronicOperations { get; set; }        // E01FL8 - max-length 8, alfanumérico

        public string CommercialOfficerCode { get; set; }       // E01OFC - max-length 4, alfanumérico
        public string SecondaryOfficerCode { get; set; }        // E01OF2 - max-length 4, alfanumérico
        public string EntityToAffiliateCode { get; set; }       // E01UC1 - max-length 4, alfanumérico

        public string SuperEntityType { get; set; }             // E01UC2 - max-length 4, alfanumérico
        public string LegalNature { get; set; }                 // E01UC3 - max-length 4, alfanumérico
        public string BusinessType { get; set; }                // E01UC4 - max-length 4, alfanumérico
        public string SegmentCode { get; set; }                 // E01UC5 - max-length 4, alfanumérico
        public string SuperEntityCode { get; set; }             // E01UC6 - max-length 4, alfanumérico

        public string AddressTypeCode { get; set; }             // E01UC7 - max-length 4, alfanumérico
        public string UndergraduateDegree { get; set; }         // E01UC9 - max-length 4, alfanumérico (Tabla 49)

        public string InterviewType { get; set; }               // E01FL3 - max-length 1, alfanumérico
        public string BankRelation { get; set; }                // E01STF - max-length 1, alfanumérico
        public string ServiceType { get; set; }                 // E01TSE - max-length 4, alfanumérico (Tabla TC)

        public double RiskPercentage { get; set; }              // E01PPA - max-length 6, numérico
    }
}
