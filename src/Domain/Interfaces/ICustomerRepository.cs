using SrfCcpCustomerMs.Domain.Entities;

namespace SrfCcpCustomerMs.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Customer? GetById(int id);
    }

    public class Customer
    {
    }
}
