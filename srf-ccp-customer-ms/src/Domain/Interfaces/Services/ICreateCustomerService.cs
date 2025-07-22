using Domain.Dtos;
using Domain.Dtos.Customer.In;

namespace Domain.Interfaces.Services;

public interface ICreateCustomerService
{
    public Task<string?> SendCreateCustomerToIbm(CreateCustomerInDto createCustomerDto);
    public Task SendCreateCustomerToIbm(string? key, CreateCustomerInDto CustomerClienteInDto);
    public Task NotifyToClient(string clientId, CreateCustomerOutDto createCustomerDto);
    public Task<List<CreateCustomerOutDto>> GetCustomerList();
    public Task<CreateCustomerOutDto?> GetCustomerById(string? id);
}
