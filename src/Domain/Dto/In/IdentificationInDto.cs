using System.Text.Json.Serialization;

namespace Domain.Dtos.Customer.In
{
    public class IdentificationInDto
    {
        public object DocumentType;
        public object ExpeditionDate;
        public object IdentificationCountry;

        [JsonPropertyName("idNumber")]
        public string IdNumber { get; set; }           // E01IDN

        [JsonPropertyName("idType")]
        public string IdType { get; set; }             // E01TID

        [JsonPropertyName("idCountry")]
        public string IdCountry { get; set; }          // E01PID

        [JsonPropertyName("idIssuePlace")]
        public string IdIssuePlace { get; set; }       // E01NM3

        [JsonPropertyName("idIssueMonth")]
        public string IdIssueMonth { get; set; }       // E01REM

        [JsonPropertyName("idIssueDay")]
        public string IdIssueDay { get; set; }         // E01RED

        [JsonPropertyName("idIssueYear")]
        public string IdIssueYear { get; set; }        // E01REY

        [JsonPropertyName("nationalityCode")]
        public string NationalityCode { get; set; }    // E01CCS

        [JsonPropertyName("fiscalEmployeeId")]
        public string FiscalEmployeeId { get; set; }   // E01RUC
    }
}
