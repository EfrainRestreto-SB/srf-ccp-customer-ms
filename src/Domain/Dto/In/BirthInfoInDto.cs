using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In
{
    public class BirthInfoInDto
    {
        [JsonPropertyName("birthMonth")]
        public required string BirthMonth { get; set; }         // E01BDM

        [JsonPropertyName("birthDay")]
        public required string BirthDay { get; set; }           // E01BDD

        [JsonPropertyName("birthYear")]
        public required string BirthYear { get; set; }          // E01BDY

        [JsonPropertyName("birthCountry")]
        public required string BirthCountry { get; set; }       // E01N5P

        [JsonPropertyName("birthDepartment")]
        public required string BirthDepartment { get; set; }    // E01N5D

        [JsonPropertyName("birthCity")]
        public required string BirthCity { get; set; }          // E01N5C
    }
}
