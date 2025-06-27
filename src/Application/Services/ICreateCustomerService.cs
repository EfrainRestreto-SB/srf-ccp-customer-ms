using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public interface ICreateCustomerService
    {
        Task NotifyToClient(string clientId, CustomerOutDto customerDto);
    }
}