using Domain.Dtos;

namespace Domain.Interfaces.Repositories;

public interface ICustomerDynamoRepository
{
    // Post: Inserta un cliente en DynamoDB
    Task InsertCustomerAsync(CustomerOutDto customer);

    // Get: Consulta un cliente por número de identificación
    Task<CustomerOutDto?> GetCustomerByNumeroIdentificacionAsync(string numeroIdentificacion);
}
