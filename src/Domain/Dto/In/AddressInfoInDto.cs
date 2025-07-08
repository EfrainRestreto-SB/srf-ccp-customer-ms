using System.Text.Json.Serialization;

namespace Domain.Dto.In
{
    public class AddressInfoInDto
    {
        public object CurrentResidenceYears;
        public object PostalType;

        [JsonPropertyName("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonPropertyName("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("department")]
        public string Department { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }

        [JsonPropertyName("addressType")]
        public string AddressType { get; set; }

        [JsonPropertyName("residenceMunicipality")]
        public string ResidenceMunicipality { get; set; }

        [JsonPropertyName("residenceDepartment")]
        public string ResidenceDepartment { get; set; }

        [JsonPropertyName("residenceCountry")]
        public string ResidenceCountry { get; set; }
    }
}
