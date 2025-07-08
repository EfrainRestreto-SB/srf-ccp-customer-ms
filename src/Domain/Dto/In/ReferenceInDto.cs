using System.Text.Json.Serialization;

namespace Domain.Dto.In
{
    public class ReferenceInDto
    {
        public readonly object SecondName;
        public readonly object FirstLastName;
        public object FirstName;
        public object SecondLastName;
        public object EmailPhoneNumber;
        public object Address;

        [JsonPropertyName("referenceType")]
        public string ReferenceType { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("surname")]
        public string Surname { get; set; }

        [JsonPropertyName("secondSurname")]
        public string SecondSurname { get; set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        [JsonPropertyName("department")]
        public string Department { get; set; }

        [JsonPropertyName("cityCode")]
        public string CityCode { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("phoneDescription")]
        public string PhoneDescription { get; set; }
    }
}
