using Domain.Dtos.Customer.In;

namespace Core.Interfaces.Services
{
    public interface ICreateCustomerService
    {
        Task CreateCustomer(CreateCustomerInDto dto);

        /// <summary>
        /// Procesa la creación de un cliente a partir del DTO de entrada.
        /// </summary>
        /// <param name="customerInDto">DTO con la información del cliente a crear</param>
        /// <returns>DTO de salida con el resultado de la operación</returns>
        Task CreateCustomerAsync(CustomerCreateInDto customerCreateInDto);
        Task CreateCustomerAsync(SrfCcpCustomerMs.Domain.Dto.Customer.In.CreateCustomerInDto dto);
        Task<Controllers.CustomerController.CreateCustomerOutDto?> GetCustomerById(string id);
        Task<List<Controllers.CustomerController.CreateCustomerOutDto>> GetCustomerList();
        Task<string?> SendCreateCustomerToIbm(Core.CreateCustomerInDto createCustomerInDto);
    }

    public class CustomerCreateOutDto
    {
    }
}
