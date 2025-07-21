using Domain.Dtos;

namespace Domain.Interfaces.Repositories;

public interface IAwsDynamoRepository
{
    public Task<List<CreateCustomerOutDto>> GetCustomerList();
    public Task InsertCreateCustomerAsync(CreateCustomerOutDto createCustomer);
    public Task<CreateCustomerOutDto?> GetCustomerListByIdAsync(string id);
}
