using SrfCcpCustomerMs.Domain.Entities;
using SrfCcpCustomerMs.Domain.Interfaces;

namespace SrfCcpCustomerMs.Persistence.Repositories
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers = new()
        {
            new Customer { Id = 1, Name = "Juan P�rez", Email = "juan@example.com" },
            new Customer { Id = 2, Name = "Ana G�mez", Email = "ana@example.com" }
        };

        public Customer? GetById(int id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }
    }
}
