namespace Domain.Models.CreateCustomer.In;

public class DescriptionsInModel
{
    public string? OfficeDescription { get; set; }            // E01BRN
    public string? ResidenceCountryDescription { get; set; }  // E01RCY
    public string? ResidenceDepartmentDescription { get; set; } // E01RDP
    public string? ResidenceCityDescription { get; set; }     // E01RCT
    public string? BirthCountryDescription { get; set; }      // E01BCY
    public string? BirthDepartmentDescription { get; set; }   // E01BDP
    public string? BirthCityDescription { get; set; }         // E01BCT
    public string? NationalityDescription { get; set; }       // E01NAT
    public string? IssuingCountryDescription { get; set; }    // E01ICO
    public string? IssuingDepartmentDescription { get; set; } // E01IDP
    public string? IssuingCityDescription { get; set; }       // E01ICT
    public string? ClientTypeDescription { get; set; }        // E01TYP
    public string? GenderDescription { get; set; }            // E01SEX
    public string? MaritalStatusDescription { get; set; }     // E01MST
    public string? LanguageDescription { get; set; }          // E01LIV
    public string? EducationLevelDescription { get; set; }    // E01EDL
    public string? EconomicSectorDescription { get; set; }    // E01SEC
    public string? EconomicActivityDescription { get; set; }  // E01ACT
    public string? RiskLevelCodeDescription { get; set; }     // E01RSC
    public string? TaxpayerTypeDescription { get; set; }      // E01TX3
    public string? SpecialTaxConditionsDescription { get; set; } // E01TX6
    public string? InterviewChannelDescription { get; set; }  // E01ICH
}
