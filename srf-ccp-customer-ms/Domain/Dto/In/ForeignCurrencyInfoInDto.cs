using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In;

public class ForeignCurrencyInfoInDto
{
    [JsonPropertyName("foreignTransactions")]
    public string ForeignTransactions { get; set; }

    [JsonPropertyName("foreignProducts")]
    public string ForeignProducts { get; set; }

    [JsonPropertyName("transaction1Amount")]
    public long Transaction1Amount { get; set; }

    [JsonPropertyName("transaction1Type")]
    public string Transaction1Type { get; set; }

    [JsonPropertyName("transaction2Amount")]
    public long Transaction2Amount { get; set; }

    [JsonPropertyName("transaction2Type")]
    public string Transaction2Type { get; set; }

    [JsonPropertyName("transaction3Amount")]
    public long Transaction3Amount { get; set; }

    [JsonPropertyName("transaction3Type")]
    public string Transaction3Type { get; set; }

    [JsonPropertyName("foreignBank1Name")]
    public string ForeignBank1Name { get; set; }

    [JsonPropertyName("foreignBank1Product")]
    public string ForeignBank1Product { get; set; }

    [JsonPropertyName("foreignBank1Currency")]
    public string ForeignBank1Currency { get; set; }

    [JsonPropertyName("foreignBank1Account")]
    public string ForeignBank1Account { get; set; }

    [JsonPropertyName("foreignBank1Balance")]
    public long ForeignBank1Balance { get; set; }

    [JsonPropertyName("foreignBank1Country")]
    public string ForeignBank1Country { get; set; }

    [JsonPropertyName("foreignBank1City")]
    public string ForeignBank1City { get; set; }

    [JsonPropertyName("isForexMarketIntermediary")]
    public string IsForexMarketIntermediary { get; set; }
}
