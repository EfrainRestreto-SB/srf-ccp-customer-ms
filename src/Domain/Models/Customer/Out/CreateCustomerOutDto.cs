namespace Domain.Dto.Out.Customer
{
    public class CreateCustomerOutDto
    {
        public string Id { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string DocumentNumber { get; set; } = default!;
        public string Status { get; set; } = "Pendiente"; // o "Creado", etc.
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
