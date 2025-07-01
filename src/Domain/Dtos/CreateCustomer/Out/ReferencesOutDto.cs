using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Dtos.CreateCustomer.Out
{
    public class ReferencesDto
    {
        [JsonPropertyName("referenceType")]
        public string? referenceType { get; set; }

        [JsonPropertyName("companyName")]
        public string? companyName { get; set; }

        [JsonPropertyName("contactName")]
        public string? contactName { get; set; }

        [JsonPropertyName("firstLastName")]
        public string? firstLastName { get; set; }

        [JsonPropertyName("secondLastName")]
        public string? secondLastName { get; set; }

        [JsonPropertyName("countryCode")]
        public string? countryCode { get; set; }

        [JsonPropertyName("departamentCode")]
        public string? departamentCode { get; set; }

        [JsonPropertyName("CityCode")]
        public string? cityCode { get; set; }

        [JsonPropertyName("landlinePhone")]
        public string? landLinePhne { get; set; }

        [JsonPropertyName("mobilePhne")]
        public string? mobilePhone { get; set; }

        [JsonPropertyName("phoneExtension")]
        public string? phoneExtension { get; set; }

        [JsonPropertyName("relationship")]
        public string? rellatonship { get; set; }
    }

}
