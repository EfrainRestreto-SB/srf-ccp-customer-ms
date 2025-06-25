using SrfCcpCustomerMs.Domain.Entities;
using SrfCcpCustomerMs.Domain.Interfaces;

namespace SrfCcpCustomerMs.Application.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public Customer? GetCustomerById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
