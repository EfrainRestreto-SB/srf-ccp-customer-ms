using SrfCcpCustomerMs.Domain.Entities;

namespace SrfCcpCustomerMs.Application.Services
{
    public interface ICustomerService
    {
        Task<string> CreateCustomerAsync(CustomerDto dto);
    }
}
