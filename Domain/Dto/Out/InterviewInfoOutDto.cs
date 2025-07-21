using System.Text.Json.Serialization;

namespace Application.Dtos.Customer.Create.Out;

public class InterviewInfoOutDto
{
    [JsonPropertyName("interviewerName")]
    public string? InterviewerName { get; set; } // E01CNM - NOMBRE DE QUIEN REALIZA ENTREVISTA

    [JsonPropertyName("interviewerId")]
    public string? InterviewerId { get; set; } // E01ID4 - NUMERO IDENTIFICACION DE QUIEN REALIZA ENTREVISTA

    [JsonPropertyName("interviewerIdType")]
    public string? InterviewerIdType { get; set; } // E01TI4 - TIPO IDENTIFICACION DE QUIEN REALIZA ENTREVISTA

    [JsonPropertyName("interviewerIdCountry")]
    public string? InterviewerIdCountry { get; set; } // E01PI4 - PAIS DE IDENTIFICACION DE QUIEN REALIZA ENTREVISTA

    [JsonPropertyName("interviewMonth")]
    public int? InterviewMonth { get; set; } // E01A1M - MES

    [JsonPropertyName("interviewDay")]
    public int? InterviewDay { get; set; } // E01A1D - DIA

    [JsonPropertyName("interviewYear")]
    public int? InterviewYear { get; set; } // E01A1Y - AÑO

    [JsonPropertyName("customerKnowledgeReport")]
    public string? CustomerKnowledgeReport { get; set; } // E01ICC - INFORME DEL CONOCIMIENTO DEL CLIENTE

    [JsonPropertyName("interviewResult")]
    public string? InterviewResult { get; set; } // E01REN - RESULTADO DE LA ENTREVISTA

    [JsonPropertyName("masterClientCode")]
    public string? MasterClientCode { get; set; } // No aparece el campo AS400 explícito en tu JSON, pero se infiere su existencia
}
