using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Dtos.CreateCustomer.Out
{
    public class BirhInfoDto
    {
        [JsonPropertyName("birhtMonth")]
        public string? birthMonth { get; set; }

        [JsonPropertyName("birhtDay")]
        public string? birthDay { get; set; }

        [JsonPropertyName("birhtYear")]
        public string? birthYear { get; set; }

        [JsonPropertyName("birhCountry")]
        public string? birthCountry { get; set; }

        [JsonPropertyName("birhtDepartament")]
        public string? birthDepartament { get; set; }

        [JsonPropertyName("birhtCity")]
        public string? birthCity{ get; set; }





    }
}
