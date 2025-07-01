using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Dtos.CreateCustomer.Out
{
    public class DescriptionsDtos
    {
        [JsonPropertyName("officeDescription")]
        public string? officeDescription { get; set; }

        [JsonPropertyName("idTypeDescription")]
        public string? idTypeDescription { get; set; }

        [JsonPropertyName("idCountryDescription")]
        public string? idCountryDescription { get; set; }

        [JsonPropertyName("nationalityDescription")]
        public string? nationalityDescription { get; set; }

        [JsonPropertyName("channelDescription")]
        public string? channelDescription { get; set; }

        [JsonPropertyName("educationDescription")]
        public string? educationDescription { get; set; }

        [JsonPropertyName("activityDescription")]
        public string? activityDescription { get; set; }

        [JsonPropertyName("riskDescription")]
        public string? riskDescription { get; set; }

        [JsonPropertyName("sectorDescription")]
        public string? sectorDescription { get; set; }

        [JsonPropertyName("residenceCountryDescription")]
        public string? residenceCountryDescription { get; set; }


        [JsonPropertyName("commercialOfficerDescription")]
        public string? commercialOfficerDescription { get; set; }

        [JsonPropertyName("secondaryOfficerDescription")]
        public string? secondaryOfficerDescription { get; set; }

        [JsonPropertyName("entityDescription")]
        public string? entityDescription { get; set; }

        [JsonPropertyName("businessTypeDescription")]
        public string? businessTypeDescription { get; set; }

        [JsonPropertyName("segmentDescription")]
        public string? segmentDescription { get; set; }


        [JsonPropertyName("degreeDescription")]
        public string? degreeDescription { get; set; }

        [JsonPropertyName("departmentDescription")]
        public string? departmentDescription { get; set; }

        [JsonPropertyName("positionDescription")]
        public string? positionDescription { get; set; }

        [JsonPropertyName("contractDescription")]
        public string? contractDescription { get; set; }

        [JsonPropertyName("transaction1Description")]
        public string? transaction1Description { get; set; }

        [JsonPropertyName("nichoDescription")]
        public string? nichoDescription { get; set; }


    }
}
