using Domain.Dtos.Customer.In;
using Domain.Dtos.Customer.Out;
using Domain.Interfaces.Services;

namespace Domain.Interfaces.Services;

public interface ICreateCustomerService
{
    Task<CustomerOutDto> CreateCustomerAsync(CreateCustomerInDto customerInDto);
    Task<CustomerOutDto?> GetCustomerById(int id);
}
