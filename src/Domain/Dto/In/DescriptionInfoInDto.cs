using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In;

public class DescriptionInfoInDto
{
    [JsonPropertyName("officeDescription")]
    public string OfficeDescription { get; set; } // D01BRA

    [JsonPropertyName("idTypeDescription")]
    public string IdTypeDescription { get; set; } // D01TID

    [JsonPropertyName("idCountryDescription")]
    public string IdCountryDescription { get; set; } // D01PID

    [JsonPropertyName("nationalityDescription")]
    public string NationalityDescription { get; set; } // D01CCS

    [JsonPropertyName("channelDescription")]
    public string ChannelDescription { get; set; } // D01RBY

    [JsonPropertyName("educationDescription")]
    public string EducationDescription { get; set; } // D01EDL

    [JsonPropertyName("activityDescription")]
    public string ActivityDescription { get; set; } // D01BUC

    [JsonPropertyName("riskDescription")]
    public string RiskDescription { get; set; } // D01RSL

    [JsonPropertyName("sectorDescription")]
    public string SectorDescription { get; set; } // D01INC

    [JsonPropertyName("residenceCountryDescription")]
    public string ResidenceCountryDescription { get; set; } // D01GEC

    [JsonPropertyName("commercialOfficerDescription")]
    public string CommercialOfficerDescription { get; set; } // D01OFC

    [JsonPropertyName("secondaryOfficerDescription")]
    public string SecondaryOfficerDescription { get; set; } // D01OF2

    [JsonPropertyName("entityDescription")]
    public string EntityDescription { get; set; } // D01UC1

    [JsonPropertyName("businessTypeDescription")]
    public string BusinessTypeDescription { get; set; } // D01UC4

    [JsonPropertyName("segmentDescription")]
    public string SegmentDescription { get; set; } // D01UC5

    [JsonPropertyName("degreeDescription")]
    public string DegreeDescription { get; set; } // D01UC9

    [JsonPropertyName("departmentDescription")]
    public string DepartmentDescription { get; set; } // D01FC4

    [JsonPropertyName("positionDescription")]
    public string PositionDescription { get; set; } // D01FC5

    [JsonPropertyName("contractDescription")]
    public string ContractDescription { get; set; } // D01EPT

    [JsonPropertyName("transaction1Description")]
    public string Transaction1Description { get; set; } // D01FXT1

    [JsonPropertyName("nichoDescription")]
    public string NichoDescription { get; set; } // D01CCL
}

