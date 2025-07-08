using static SrfCcpCustomerMs.Domain.Models;

namespace SrfCcpCustomerMs.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Task CreateAsync(object customerEntity);
        Task GetByDocumentNumberAsync(string documentNumber);
        Domain.Models.Customer? GetById(int id);
    }
}

public interface ICustomerRepository
{
    Task SaveCustomerAsync(Customer customer);
}
