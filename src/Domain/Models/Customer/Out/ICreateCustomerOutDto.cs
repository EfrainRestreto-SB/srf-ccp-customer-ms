
namespace Domain.Dto.Out.Customer
{
    public interface ICreateCustomerOutDto
    {
        DateTime CreatedAt { get; set; }
        string DocumentNumber { get; set; }
        string Estado { get; set; }
        string FirstName { get; set; }
        string Id { get; set; }
        string LastName { get; set; }
        string Status { get; set; }
    }
}