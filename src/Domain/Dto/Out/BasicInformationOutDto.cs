using System.Text.Json.Serialization;

namespace Domain.Dto.In
{
    public class BasicInformationOutDto
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("secondName")]
        public string SecondName { get; set; }

        [JsonPropertyName("firstLastName")]
        public string FirstLastName { get; set; }

        [JsonPropertyName("secondLastName")]
        public string SecondLastName { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("civilStatus")]
        public string CivilStatus { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("educationLevel")]
        public string EducationLevel { get; set; }

        [JsonPropertyName("economicActivity")]
        public string EconomicActivity { get; set; }

        [JsonPropertyName("economicActivityCode")]
        public string EconomicActivityCode { get; set; }

        [JsonPropertyName("riskCode")]
        public string RiskCode { get; set; }

        [JsonPropertyName("pepStatus")]
        public string PEPStatus { get; set; }

        [JsonPropertyName("unhcr")]
        public string UNHCR { get; set; }

        [JsonPropertyName("disability")]
        public string Disability { get; set; }

        [JsonPropertyName("ethnicGroup")]
        public string EthnicGroup { get; set; }

        [JsonPropertyName("channelCode")]
        public string ChannelCode { get; set; }

        [JsonPropertyName("residencyCondition")]
        public string ResidencyCondition { get; set; }

        [JsonPropertyName("geographicLocation")]
        public string GeographicLocation { get; set; }
    }
}
