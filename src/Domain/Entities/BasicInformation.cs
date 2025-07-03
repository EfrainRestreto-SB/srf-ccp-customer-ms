namespace Domain.Entities;

public class BasicInformation
{
    public string DocumentType { get; set; } = null!;
    public string DocumentNumber { get; set; } = null!;
    public string FullName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
}
