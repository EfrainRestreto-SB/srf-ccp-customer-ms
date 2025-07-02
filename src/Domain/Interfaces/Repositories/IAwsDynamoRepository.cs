using Domain.Dtos;

namespace Domain.Interfaces.Repositories;

public interface IAwsDynamoRepository
{
    Task<CustomerCreateOutDto?> GetCustomerByIdAsync(string v);
    Task<List<CustomerCreateOutDto>> GetCustomerList();
}
public interface IInsertCustomerRepository : IAwsDynamoRepository
{
    Task InsertCreateCustomerAsync(CustomerCreateOutDto dto);
}
public interface ICustomerDynamoRepository
{
    // Post: Inserta un cliente en DynamoDB
    Task InsertCustomerAsync(CustomerOutDto customer);

    // Get: Consulta un cliente por número de identificación
    Task<CustomerOutDto?> GetCustomerByNumeroIdentificacionAsync(string numeroIdentificacion);
}
