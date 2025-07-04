using Domain.Dtos;
using Domain.Dtos.CreateSavingsAccount.Out;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services;

public interface ICreateCustomerService
{
    Task<string?> SendCreateCustomerToIbm(CustomerCreateInDto customerCreateInDto);

    Task SendCreateCustomerToIbm(string? key, CustomerCreateInDto customerCreateInDto);

    Task NotifyToClient(string clientId, CustomerCreateOutDto customerCreateOutDto);

    Task<List<CustomerCreateOutDto>> GetCustomerList();

    Task<CustomerCreateOutDto?> GetCustomerById(string? id);
}
