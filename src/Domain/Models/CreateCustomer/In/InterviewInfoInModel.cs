namespace Domain.Models.CreateCustomer.In;

public class InterviewInfoInModel
{
    public string? InterviewChannel { get; set; }           // E01ICH
    public string? InterviewDate { get; set; }              // E01IDT (Formato: yyyyMMdd)
    public string? InterviewedBy { get; set; }              // E01IOF
    public string? InterviewObservations { get; set; }      // E01IOB
}
