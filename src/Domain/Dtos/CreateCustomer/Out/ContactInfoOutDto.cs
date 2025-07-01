using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Dtos.CreateCustomer.Out
{
    public class ContactInfoDto
    {
        [JsonPropertyName("addressLine1")]
        public string? addressline1 { get; set; }

        [JsonPropertyName("AdressLine2")]
        public string? AdressLine2 { get; set; }

        [JsonPropertyName("AdressLine3")]
        public string? AdressLine3 { get; set; }

        [JsonPropertyName("City")]
        public string? City { get; set; }

        [JsonPropertyName("CityCode")]
        public string? CityCode { get; set; }

        [JsonPropertyName("postalCode")]
        public string? postalCode { get; set; }

        [JsonPropertyName("recidenceCountry")]
        public string? recidenceCountry { get; set; }


        [JsonPropertyName("currentRecidenceYears")]
        public string? currentRecidenceYears { get; set; }

        [JsonPropertyName("currentRecidenceMonth")]
        public string? currentRecidenceMonth { get; set; }

        [JsonPropertyName("housingType")]
        public string? housingType { get; set; }



    }
}
