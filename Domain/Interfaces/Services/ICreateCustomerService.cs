using Core;
using Domain.Dtos;

namespace Domain.Interfaces.Services;

public interface ICreateCustomerService
{
    public Task<string?> SendCreateCdtToIbm(CreateCustomerInDto createCdtDto);
    public Task SendCreateCdtToIbm(string? key, CreateCustomerInDto cdtClienteInDto);
    public Task NotifyToClient(string clientId, CreateCustomerOutDto createCdtDto);
    public Task<List<CreateCustomerOutDto>> GetCdtList();
    public Task<CreateCustomerOutDto?> GetCdtById(string? id);
    Task<CreateCustomerOutDto?> GetCustomerById(string? requestId);
    Task SendCreateCustomerToIbm(string clientId, Dtos.Customer.In.CreateCustomerInDto createCustomerInDto);
    Task<string?> SendCreateCustomerToIbm(CreateCustomerInDto createCdtInDto);
    Task<List<CreateCustomerOutDto>> GetCustomerList();
}
