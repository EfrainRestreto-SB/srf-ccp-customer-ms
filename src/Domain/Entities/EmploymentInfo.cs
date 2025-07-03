namespace Domain.Entities.Customer;

public class EmploymentInfo
{
    public string Occupation { get; set; } = default!;
    public string EmployerName { get; set; } = default!;
    public int YearsInCurrentJob { get; set; }
}
