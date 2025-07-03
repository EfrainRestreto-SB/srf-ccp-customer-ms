using Domain.Entities;

namespace Domain.Interfaces.Repositories;

public interface IAwsDynamoRepository
{
 
    Task<Customer?> GetCustomerByIdAsync(string id);

  
    Task SaveCustomerAsync(Customer customer);

  
    Task<List<Customer>> GetAllCustomersAsync();
}
