using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In;

public class FinancialInfoInDto
{
    [JsonPropertyName("monthlyIncome")]
    public long MonthlyIncome { get; set; }

    [JsonPropertyName("otherIncome")]
    public long OtherIncome { get; set; }

    [JsonPropertyName("familyExpenses")]
    public long FamilyExpenses { get; set; }

    [JsonPropertyName("totalLiabilities")]
    public long TotalLiabilities { get; set; }

    [JsonPropertyName("otherAssets")]
    public long OtherAssets { get; set; }

    [JsonPropertyName("realStateAssets")]
    public long RealStateAssets { get; set; }

    [JsonPropertyName("totalAssets")]
    public long TotalAssets { get; set; }

    [JsonPropertyName("totalIncome")]
    public long TotalIncome { get; set; }

    [JsonPropertyName("totalExpenses")]
    public long TotalExpenses { get; set; }

    [JsonPropertyName("fundsOriginDescription1")]
    public string FundsOriginDescription1 { get; set; }

    [JsonPropertyName("fundsOriginDescription2")]
    public string FundsOriginDescription2 { get; set; }

    [JsonPropertyName("fundsOriginDescription3")]
    public string FundsOriginDescription3 { get; set; }
}
