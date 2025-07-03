namespace Domain.Entities.Customer;

public class Identification
{
    public string DocumentType { get; set; } = default!;
    public string DocumentNumber { get; set; } = default!;
    public DateTime IssueDate { get; set; }
    public string IssuingAuthority { get; set; } = default!;
}
