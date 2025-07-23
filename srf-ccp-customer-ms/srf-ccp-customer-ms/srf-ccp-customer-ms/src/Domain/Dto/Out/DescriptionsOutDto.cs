using System.Text.Json.Serialization;

public class DescriptionsOutDto
{
    [JsonPropertyName("officeDescription")]
    public string OfficeDescription { get; set; }

    [JsonPropertyName("idTypeDescription")]
    public string IdTypeDescription { get; set; }

    [JsonPropertyName("idCountryDescription")]
    public string IdCountryDescription { get; set; }

    [JsonPropertyName("nationalityDescription")]
    public string NationalityDescription { get; set; }

    [JsonPropertyName("channelDescription")]
    public string ChannelDescription { get; set; }

    [JsonPropertyName("educationDescription")]
    public string EducationDescription { get; set; }

    [JsonPropertyName("activityDescription")]
    public string ActivityDescription { get; set; }

    [JsonPropertyName("riskDescription")]
    public string RiskDescription { get; set; }

    [JsonPropertyName("sectorDescription")]
    public string SectorDescription { get; set; }

    [JsonPropertyName("residenceCountryDescription")]
    public string ResidenceCountryDescription { get; set; }

    [JsonPropertyName("commercialOfficerDescription")]
    public string CommercialOfficerDescription { get; set; }

    [JsonPropertyName("secondaryOfficerDescription")]
    public string SecondaryOfficerDescription { get; set; }

    [JsonPropertyName("entityDescription")]
    public string EntityDescription { get; set; }

    [JsonPropertyName("businessTypeDescription")]
    public string BusinessTypeDescription { get; set; }

    [JsonPropertyName("segmentDescription")]
    public string SegmentDescription { get; set; }

    [JsonPropertyName("degreeDescription")]
    public string DegreeDescription { get; set; }

    [JsonPropertyName("departmentDescription")]
    public string DepartmentDescription { get; set; }

    [JsonPropertyName("positionDescription")]
    public string PositionDescription { get; set; }

    [JsonPropertyName("contractDescription")]
    public string ContractDescription { get; set; }

    [JsonPropertyName("transaction1Description")]
    public string Transaction1Description { get; set; }

    [JsonPropertyName("nichoDescription")]
    public string NichoDescription { get; set; }
}
