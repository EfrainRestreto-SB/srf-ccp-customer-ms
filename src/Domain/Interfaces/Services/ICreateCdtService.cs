namespace Core.Interfaces.Services
{
    public interface ICreateCustomerService
    {
        /// <summary>
        /// Procesa la creación de un cliente a partir del DTO de entrada.
        /// </summary>
        /// <param name="customerInDto">DTO con la información del cliente a crear</param>
        /// <returns>DTO de salida con el resultado de la operación</returns>
        Task<CustomerCreateOutDto> CreateCustomerAsync(Domain.Dto.In.CustomerCreateOutDto customerInDto);
    }

    public class CustomerCreateOutDto
    {
    }
}
