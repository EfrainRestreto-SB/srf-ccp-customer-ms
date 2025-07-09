using System.Text.Json.Serialization;

namespace Domain.Dto.In
{
    public class AddressInfoInDto
    {
        [JsonPropertyName("currentResidenceYears")]
        public string CurrentResidenceYears { get; set; } = default!;

        [JsonPropertyName("postalType")]
        public string PostalType { get; set; } = default!;

        [JsonPropertyName("addressLine1")]
        public required string AddressLine1 { get; set; }

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
