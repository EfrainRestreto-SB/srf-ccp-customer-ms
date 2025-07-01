namespace Domain.Models.CreateCustomer.In;

public class ContactInfoInModel
{
    public string? EmailType { get; set; }          // E01TAT
    public string? Email { get; set; }              // E01EML
    public string? PhoneType { get; set; }          // E01TYP
    public string? PhoneNumber { get; set; }        // E01PHN
    public string? PhoneDescription { get; set; }   // E01PHX
}
