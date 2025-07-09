using System.Text.Json.Serialization;

namespace Domain.Dto.In
{
    public class DescriptionInfoInDto
    {
        public readonly object EconomicActivityDescription;
        public object GenderDescription;
        public object CountryDescription;
        public object DocumentTypeDescription;
        public object BirthCityDescription;
        public object InterviewResultDescription;

        [JsonPropertyName("officeDescription")]
        public string OfficeDescription { get; set; }

        [JsonPropertyName("identificationDescription")]
        public string IdentificationDescription { get; set; }

        [JsonPropertyName("nationalityDescription")]
        public string NationalityDescription { get; set; }

        [JsonPropertyName("professionDescription")]
        public string ProfessionDescription { get; set; }

        [JsonPropertyName("riskDescription")]
        public string RiskDescription { get; set; }

        [JsonPropertyName("disabilityDescription")]
        public string DisabilityDescription { get; set; }

        [JsonPropertyName("channelDescription")]
        public string ChannelDescription { get; set; }

        [JsonPropertyName("geographicLocationDescription")]
        public string GeographicLocationDescription { get; set; }

        [JsonPropertyName("departmentDescription")]
        public string DepartmentDescription { get; set; }

        [JsonPropertyName("cityDescription")]
        public string CityDescription { get; set; }

        [JsonPropertyName("municipalityDescription")]
        public string MunicipalityDescription { get; set; }

        [JsonPropertyName("residenceDescription")]
        public string ResidenceDescription { get; set; }
    }
}
