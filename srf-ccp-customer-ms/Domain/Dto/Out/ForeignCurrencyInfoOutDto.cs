using System.Text.Json.Serialization;

public class ForeignCurrencyInfoOutDto
{
    [JsonPropertyName("foreignTransactions")]
    public string ForeignTransactions { get; set; } // E01FX - Y/N

    [JsonPropertyName("foreignProducts")]
    public string ForeignProducts { get; set; } // E01FXP - Y/N

    [JsonPropertyName("transaction1Amount")]
    public long Transaction1Amount { get; set; } // E01FXA1

    [JsonPropertyName("transaction1Type")]
    public string Transaction1Type { get; set; } // E01FXT1

    [JsonPropertyName("transaction2Amount")]
    public long Transaction2Amount { get; set; } // E01FXA2

    [JsonPropertyName("transaction2Type")]
    public string Transaction2Type { get; set; } // E01FXT2

    [JsonPropertyName("transaction3Amount")]
    public long Transaction3Amount { get; set; } // E01FXA3

    [JsonPropertyName("transaction3Type")]
    public string Transaction3Type { get; set; } // E01FXT3

    [JsonPropertyName("foreignBank1Name")]
    public string ForeignBank1Name { get; set; } // E01FXE1

    [JsonPropertyName("foreignBank1Product")]
    public string ForeignBank1Product { get; set; } // E01FXP1

    [JsonPropertyName("foreignBank1Currency")]
    public string ForeignBank1Currency { get; set; } // E01FXC1

    [JsonPropertyName("foreignBank1Account")]
    public string ForeignBank1Account { get; set; } // E01FXN1

    [JsonPropertyName("foreignBank1Balance")]
    public long ForeignBank1Balance { get; set; } // E01FXPA1

    [JsonPropertyName("foreignBank1Country")]
    public string ForeignBank1Country { get; set; } // E01FXO1

    [JsonPropertyName("foreignBank1City")]
    public string ForeignBank1City { get; set; } // E01FXU1

    [JsonPropertyName("isForexMarketIntermediary")]
    public string IsForexMarketIntermediary { get; set; } // E1FL06 - Y/N
}
