namespace Domain.Models.CreateCustomer.In;

public class IdentificationInModel
{
    public string? IdNumber { get; set; } // E01IDN - max 25 - alfanumérico
    public string? IdType { get; set; } // E01TID - max 4 - alfanumérico
    public string? IdCountry { get; set; } // E01PID - max 4 - alfanumérico
    public string? IdIssuePlace { get; set; } // E01NM3 - max 45 - alfanumérico
    public int? IdIssueMonth { get; set; } // E01REM - max 2 - numérico
    public int? IdIssueDay { get; set; } // E01RED - max 2 - numérico
    public int? IdIssueYear { get; set; } // E01REY - max 4 - numérico
    public string? NationalityCode { get; set; } // E01CCS - max 4 - alfanumérico
    public string? FiscalEmployeeId { get; set; } // E01RUC - max 25 - alfanumérico
}
