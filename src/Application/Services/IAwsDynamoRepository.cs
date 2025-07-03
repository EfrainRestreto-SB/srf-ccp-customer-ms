// En archivo Domain/Interfaces/Repositories/IAwsDynamoRepository.cs
using Domain.Dtos;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IAwsDynamoRepository
    {
        Task SaveCustomerAsync(string clientId, CustomerOutDto customerDto);

        // Otros métodos que puedas necesitar
        Task<CustomerOutDto> GetCustomerAsync(string clientId);
        Task DeleteCustomerAsync(string clientId);
        Task<bool> CustomerExistsAsync(string clientId);
        Task SaveCustomerAsync(string clientId, Dtos.Customer.Out.CustomerOutDto customerDto);
    }
}