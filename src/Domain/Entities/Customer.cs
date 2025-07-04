namespace Domain.Entities;

// Renamed the class to avoid conflict with another 'Customer' definition in the same namespace.
public class CustomerEntity
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
}
