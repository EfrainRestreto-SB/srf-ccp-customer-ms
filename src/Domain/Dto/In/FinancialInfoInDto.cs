using System.Text.Json.Serialization;

namespace Domain.Dto.In
{
    public class FinancialInfoOutDto
    {
        public object FamilyExpenses;
        public object OtherAssets;
        public object OtherLiabilities;
        public object TotalAssets;
        public object TotalLiabilities;
        public object FundsDestination;
        public object FundsDestinationDescription;

        [JsonPropertyName("income")]
        public string Income { get; set; }

        [JsonPropertyName("otherIncome")]
        public string OtherIncome { get; set; }

        [JsonPropertyName("incomeSource")]
        public string IncomeSource { get; set; }

        [JsonPropertyName("otherIncomeSource")]
        public string OtherIncomeSource { get; set; }

        [JsonPropertyName("incomeFrequency")]
        public string IncomeFrequency { get; set; }

        [JsonPropertyName("totalIncome")]
        public string TotalIncome { get; set; }

        [JsonPropertyName("totalExpenses")]
        public string TotalExpenses { get; set; }

        [JsonPropertyName("fundsOrigin")]
        public string FundsOrigin { get; set; }

        [JsonPropertyName("fundsUse")]
        public string FundsUse { get; set; }

        [JsonPropertyName("fundsOriginDescription")]
        public string FundsOriginDescription { get; set; }

        [JsonPropertyName("fundsUseDescription")]
        public string FundsUseDescription { get; set; }
    }
}
