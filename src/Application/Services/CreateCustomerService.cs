using Domain.Dtos;
using Domain.Dtos.CreateCustomer.In;
using Domain.Dtos.CreateCustomer.Out;
using Domain.Interfaces.Services;

namespace Application.Services;

public class CreateCustomerService : ICreateCustomerService
{
    public async Task<string> SendCreateCustomerToIbm(CustomerCreateInDto dto)
    {
        await Task.Delay(500);
        return Guid.NewGuid().ToString(); 
    }

    public async Task<List<CustomerCreateOutDto>> GetCustomerList()
    {
        await Task.Delay(300); // Simular latencia
        return new List<CustomerCreateOutDto>
        {
            new() { Id = "1", Name = "Juan Pérez", Email = "juan@example.com" },
            new() { Id = "2", Name = "Laura Gómez", Email = "laura@example.com" }
        };
    }

    public async Task<CustomerCreateOutDto?> GetCustomerById(string id)
    {
        await Task.Delay(300);
        if (id == "1")
            return new CustomerCreateOutDto { Id = "1", Name = "Juan Pérez", Email = "juan@example.com" };
        return null;
    }
}
