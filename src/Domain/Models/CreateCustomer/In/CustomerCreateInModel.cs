namespace Domain.Models.CreateCustomer.In;

public class CustomerCreateInModel
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public BasicInformationInModel BasicInformation { get; set; } = new(); // ✅ tipo específico
}
