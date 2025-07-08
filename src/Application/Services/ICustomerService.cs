namespace Application.Interfaces
{
    public interface ICustomerService
    {
        Task<CustomerCreateOutDto> CreateCustomerAsync(Domain.Dto.In.CustomerCreateOutDto customerDto);
        Task<object> CreateCustomerAsync(Domain.Dto.In.CustomerCreateInDto customerCreateInDto);
        Task<CustomerCreateOutDto?> GetCustomerByDocumentAsync(string documentNumber);
    }

    public class CustomerCreateOutDto
    {
        public string CustomerId;
    }
}
