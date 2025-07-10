using Controllers;
using Domain.Dtos.Customer.In;
using Domain.Dtos.Customer.Out;

namespace Core.Interfaces.Services
{
    public interface ICreateCustomerService
    {
        Task<List<CustomerController.CreateCustomerOutDto>> CustomerList { get; }

        Task CreateCustomer(CreateCustomerInDto dto);
        Task<List<CreateCustomerOutDto>> GetCustomerList();
        Task<CreateCustomerOutDto?> GetCustomerById(string id);
        Task CreateCustomerAsync(CustomerCreateInDto customerCreateInDto);
    }
}
