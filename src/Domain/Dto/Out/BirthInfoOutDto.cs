using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.In
{
    internal class BirthInfoOutDto
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("department")]
        public string Department { get; set; }

        [JsonPropertyName("municipality")]
        public string Municipality { get; set; }

        [JsonPropertyName("birthDate")]
        public string BirthDate { get; set; }
    }
}
