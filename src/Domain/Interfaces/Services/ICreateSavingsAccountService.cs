using Domain.Dtos;
using Domain.Dtos.CreateCustomer.In;
using Domain.Dtos.CreateCustomer.Out;

namespace Domain.Interfaces.Services;

public interface ICreateCustomerService
{
    Task<string> SendCreateCustomerToIbm(CustomerCreateInDto dto);
    Task<List<CustomerCreateOutDto>> GetCustomerList();
    Task<CustomerCreateOutDto?> GetCustomerById(string id);
}
