using Domain.Dtos;
using Domain.Interfaces.Repositories;

namespace Domain.Interfaces.Services
{
    public interface ICreateCustomerService
    {
        Task NotifyToClient(string clientId, CustomerOutDto customerOutDto);

        // Consulta por número de identificación del cliente
        Task<CustomerOutDto?> GetCustomerById(string? numeroIdentificacion);
        Task<string?> SendCreateCustomerToIbm(object customerDto);
        Task GetCustomerList();
    }
}
