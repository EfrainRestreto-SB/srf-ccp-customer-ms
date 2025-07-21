using Core;
using Domain.Dtos;

namespace Domain.Interfaces.Services;

public interface ICreateCustomerService
{
    public Task<string?> SendCreateCustomerToIbm(CreateCustomerInDto createCustomerDto);
    public Task SendCreateCustomerToIbm(string? key, CreateCustomerInDto CustomerClienteInDto);
    public Task NotifyToClient(string clientId, CreateCustomerInDto createCustomerDto);
    public Task<List<CreateCustomerOutDto>> GetCustomerList();
    public Task<CreateCustomerOutDto?> GetCustomerById(string? id);
    Task SendCreateCustomerToIbm(string clientId, Dtos.Customer.In.CreateCustomerInDto createCustomerInDto);
}
