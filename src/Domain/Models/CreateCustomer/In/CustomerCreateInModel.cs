namespace Domain.Models.CreateCustomer.In;

public class CustomerCreateInModel
{
    public string Id { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public object BasicInformation { get; set; }
}
