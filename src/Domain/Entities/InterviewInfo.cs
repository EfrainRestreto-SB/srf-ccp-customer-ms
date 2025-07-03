namespace Domain.Entities.Customer;

public class InterviewInfo
{
    public string InterviewedBy { get; set; } = default!;
    public DateTime InterviewDate { get; set; }
    public string InterviewLocation { get; set; } = default!;
}
