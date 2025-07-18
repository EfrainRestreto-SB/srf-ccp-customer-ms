using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In;

public class IdentificationInDto
{
    [JsonPropertyName("idNumber")]
    public string IdNumber { get; set; }

    [JsonPropertyName("idType")]
    public string IdType { get; set; }

    [JsonPropertyName("idCountry")]
    public string IdCountry { get; set; }

    [JsonPropertyName("idIssuePlace")]
    public string IdIssuePlace { get; set; }

    [JsonPropertyName("idIssueMonth")]
    public int? IdIssueMonth { get; set; }

    [JsonPropertyName("idIssueDay")]
    public int? IdIssueDay { get; set; }

    [JsonPropertyName("idIssueYear")]
    public int? IdIssueYear { get; set; }

    [JsonPropertyName("nationalityCode")]
    public string NationalityCode { get; set; }

    [JsonPropertyName("fiscalEmployeeId")]
    public string FiscalEmployeeId { get; set; }
}
