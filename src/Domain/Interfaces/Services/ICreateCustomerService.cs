using Core;
using Domain.Dtos;

namespace Domain.Interfaces.Services;

public interface ICreateCdtService
{
    public Task<string?> SendCreateCdtToIbm(CreateCustomerInDto createCustomerDto);
    public Task SendCreateCdtToIbm(string? key, CreateCustomerInDto CustomerClienteInDto);
    public Task NotifyToClient(string clientId, CreateCustomerInDto createCustomerDto);
    public Task<List<CreateCustomerOutDto>> GetCdtList();
    public Task<CreateCustomerOutDto?> GetCdtById(string? id);
}
