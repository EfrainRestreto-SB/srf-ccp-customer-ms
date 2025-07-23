using System.Text.Json.Serialization;

public class FinancialInfoOutDto
{
    [JsonPropertyName("monthlyIncome")]
    public required decimal MonthlyIncome { get; set; }

    [JsonPropertyName("otherIncome")]
    public required decimal OtherIncome { get; set; }

    [JsonPropertyName("familyExpenses")]
    public required decimal FamilyExpenses { get; set; }

    [JsonPropertyName("totalLiabilities")]
    public required decimal TotalLiabilities { get; set; }

    [JsonPropertyName("otherAssets")]
    public required decimal OtherAssets { get; set; }

    [JsonPropertyName("realStateAssets")]
    public required decimal RealStateAssets { get; set; }

    [JsonPropertyName("totalAssets")]
    public required decimal TotalAssets { get; set; }

    [JsonPropertyName("totalIncome")]
    public required decimal TotalIncome { get; set; }

    [JsonPropertyName("totalExpenses")]
    public required decimal TotalExpenses { get; set; }

    [JsonPropertyName("fundsOriginDescription1")]
    public required string FundsOriginDescription1 { get; set; }

    [JsonPropertyName("fundsOriginDescription2")]
    public required string FundsOriginDescription2 { get; set; }

    [JsonPropertyName("fundsOriginDescription3")]
    public required string FundsOriginDescription3 { get; set; }
}
