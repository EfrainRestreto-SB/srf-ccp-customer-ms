
namespace Persistence.Repositories
{
    public interface IAwsDynamoCustomerRepository
    {
        Task<CreateCustomerOutDto?> GetCustomerByNumeroIdentificacionAsync(string numeroIdentificacion);
        Task InsertCustomerAsync(CreateCustomerOutDto customer);
    }
}