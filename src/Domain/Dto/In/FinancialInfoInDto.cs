using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In
{
    public class FinancialInfoInDto
    {
        [JsonPropertyName("monthlyIncome")]
        public string MonthlyIncome { get; set; }         // E01AM2

        [JsonPropertyName("otherIncome")]
        public string OtherIncome { get; set; }           // E01AM4

        [JsonPropertyName("familyExpenses")]
        public string FamilyExpenses { get; set; }        // E01AM1

        [JsonPropertyName("totalLiabilities")]
        public string TotalLiabilities { get; set; }      // E01AM3

        [JsonPropertyName("otherAssets")]
        public string OtherAssets { get; set; }           // E01AM5

        [JsonPropertyName("realStateAssets")]
        public string RealStateAssets { get; set; }       // E01FM2

        [JsonPropertyName("totalAssets")]
        public string TotalAssets { get; set; }           // E01AMT

        [JsonPropertyName("totalIncome")]
        public string TotalIncome { get; set; }           // E01AM8

        [JsonPropertyName("totalExpenses")]
        public string TotalExpenses { get; set; }         // E01FM3

        [JsonPropertyName("fundsOriginDescription1")]
        public string FundsOriginDescription1 { get; set; } // E01DS2

        [JsonPropertyName("fundsOriginDescription2")]
        public string FundsOriginDescription2 { get; set; } // E01DS3

        [JsonPropertyName("fundsOriginDescription3")]
        public string FundsOriginDescription3 { get; set; } // E01DS4
    }
}
