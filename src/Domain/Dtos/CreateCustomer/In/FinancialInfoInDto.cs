using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Dtos.CreateCustomer.In
{
    public class FinancialInfoInDto
    {
        [JsonPropertyName("monthlyIncome")]
        public string? montlyIncome { get; set; }

        [JsonPropertyName("otherIncome")]
        public string? otherIncome { get; set; }

        [JsonPropertyName("familyExpenses")]
        public string? familyExpenses { get; set; }

        [JsonPropertyName("totalLiabilities")]
        public string? totalLiabilities { get; set; }

        [JsonPropertyName("othersAssets")]
        public string? otherAssests { get; set; }

        [JsonPropertyName("realStateAssets")]
        public string? realStateAssets { get; set; }

        [JsonPropertyName("totalAssets")]
        public string? totalAssets { get; set; }

        [JsonPropertyName("totalIncome")]
        public string? totalIncome { get; set; }

        [JsonPropertyName("totaExpense")]
        public string? totalExpense { get; set; }

        [JsonPropertyName("foundsOriginDescription1")]
        public string? foundOriginDescription2 { get; set; }

        [JsonPropertyName("foundsOriginDescription3")]
        public string? foundsOriginDescription3 { get; set; }



    }
}
