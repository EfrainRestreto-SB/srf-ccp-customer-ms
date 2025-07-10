using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In
{
    public class AddressInfoInDto
    {
        public object Department;

        [JsonPropertyName("addressLine1")]
        public string AddressLine1 { get; set; }        // E01NA2

        [JsonPropertyName("addressLine2")]
        public string AddressLine2 { get; set; }        // E01NA3

        [JsonPropertyName("addressLine3")]
        public string AddressLine3 { get; set; }        // E01NA4

        [JsonPropertyName("city")]
        public string City { get; set; }                // E01CTY

        [JsonPropertyName("cityCode")]
        public string CityCode { get; set; }            // E01STE

        [JsonPropertyName("country")]
        public string Country { get; set; }             // E01CTR

        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }          // E01ZPC

        [JsonPropertyName("residenceCountry")]
        public string ResidenceCountry { get; set; }    // E01GEC

        [JsonPropertyName("currentResidenceYears")]
        public string CurrentResidenceYears { get; set; } // E01TVY

        [JsonPropertyName("currentResidenceMonths")]
        public string CurrentResidenceMonths { get; set; } // E01TVM

        [JsonPropertyName("housingType")]
        public string HousingType { get; set; }         // E01FG1
    }
}
