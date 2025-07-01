namespace Domain.Models.CreateCustomer.Out;

public class ContactInfoOutModel
{
    public string? Email { get; set; }               // E01EML
    public string? PhoneNumber { get; set; }         // E01PHN
    public string? MobileNumber { get; set; }        // E01CEL
    public string? Address { get; set; }             // E01ADR
}
