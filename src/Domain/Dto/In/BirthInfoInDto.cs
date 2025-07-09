using System.Text.Json.Serialization;

namespace Domain.Dto.In
{
    public class BirthInfoInDto
    {
        public object BirthCountry;
        public object BirthDepartment;
        public object BirthCity;

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
