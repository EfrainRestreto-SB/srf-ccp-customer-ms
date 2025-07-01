using System.Text.Json.Serialization;

namespace Domain.Dtos.CreateCustomer.In;

public class IdentificationDto
{
    [JsonPropertyName("Number")]
    public string? Number { get; set; }

    [JsonPropertyName("Type")]
    public string? IdType { get; set; }

    [JsonPropertyName("Country")]
    public string? country { get; set; }

    [JsonPropertyName("SueePlace")]
    public string? Sueeplace { get; set; }

    [JsonPropertyName("SueeMonth")]
    public string? SueeMonth { get; set; }


    [JsonPropertyName("issueDay")]
    public string? issueDay { get; set; }

    [JsonPropertyName("issueyear")]
    public string? ssueyear { get; set; }


    [JsonPropertyName("nationality")]
    public string? Nationality { get; set; }


    [JsonPropertyName("FiscalEmployee")]
    public string? FiscalEmployee { get; set; }


}

