namespace Domain.Models.Customer
{
    public class FinancialInfoInModel
    {
        public long MonthlyIncome { get; set; }               // E01AM2  - max 20 numérico
        public long OtherIncome { get; set; }                 // E01AM4  - max 20 numérico
        public long FamilyExpenses { get; set; }              // E01AM1  - max 20 numérico
        public long TotalLiabilities { get; set; }            // E01AM3  - max 20 numérico
        public long OtherAssets { get; set; }                 // E01AM5  - max 20 numérico
        public long RealStateAssets { get; set; }             // E01FM2  - max 20 numérico
        public long TotalAssets { get; set; }                 // E01AMT  - max 20 numérico
        public long TotalIncome { get; set; }                 // E01AM8  - max 20 numérico (Solo salida)
        public long TotalExpenses { get; set; }               // E01FM3  - max 20 numérico

        public string FundsOriginDescription1 { get; set; }   // E01DS2  - max 60 alfanumérico
        public string FundsOriginDescription2 { get; set; }   // E01DS3  - max 60 alfanumérico
        public string FundsOriginDescription3 { get; set; }   // E01DS4  - max 60 alfanumérico
    }
}
