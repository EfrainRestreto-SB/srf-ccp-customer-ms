using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Dtos.CreateCustomer.Out
{
    public class ForeignCurrencyInfoDto
    {
        [JsonPropertyName("ForeignTranssactions")]
        public string? ForeignTranssactions { get; set; }

        [JsonPropertyName("ForeignProducts")]
        public string? ForeignProducts { get; set; }

        [JsonPropertyName("transaction1Amount")]
        public string? trasnsanction1Amounnt { get; set; }

        [JsonPropertyName("transaction1Type")]
        public string? trasnsanction1Type { get; set; }

        [JsonPropertyName("transaction2Amount")]
        public string? trasnsanction2Amounnt { get; set; }

        [JsonPropertyName("transaction2Type")]
        public string? trasnsanction2Type { get; set; }

        [JsonPropertyName("transaction3Amount")]
        public string? trasnsanction3Amounnt { get; set; }

        [JsonPropertyName("transaction3Type")]
        public string? trasnsanction3Type { get; set; }

        [JsonPropertyName("foringBank1Namne")]
        public string? foringBank1Namne { get; set; }

        [JsonPropertyName("foringBank1Product")]
        public string? foringBank1Product { get; set; }

        [JsonPropertyName("foringBank1Currency")]
        public string? foringBank1Currency { get; set; }

        [JsonPropertyName("foringBank1Account")]
        public string? foringBank1Account { get; set; }

        [JsonPropertyName("foringBank1Balance")]
        public string? foringBank1Balance { get; set; }

        [JsonPropertyName("foringBank1Country")]
        public string? foringBank1Country { get; set; }

        [JsonPropertyName("foringBank1City")]
        public string? foringBank1City { get; set; }

        [JsonPropertyName("isForexMarkeIntermediary")]
        public string? isForezMarkeIntermediary { get; set; }

    }
}
