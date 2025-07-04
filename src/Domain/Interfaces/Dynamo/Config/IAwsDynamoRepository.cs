using Domain.Dtos.CreateSavingsAccount.Out;
using Domain.Models.Customer.In;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories;

public interface IAwsDynamoRepository
{
    public Task<List<CustomerCreateOutDto>> GetCreateCustomers();

    // Fixing syntax errors and method declaration issues
    public Task InsertCreateCustomerAsync(CustomerCreateOutDto createCustomer);

    public Task<CustomerCreateOutDto?> GetCustomerListByIdAsync(string customerId);
}
