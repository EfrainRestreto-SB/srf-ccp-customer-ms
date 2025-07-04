using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories;

public interface IAwsDynamoRepository<T>
{
    Task SaveAsync(string id, T entity);
    Task<T?> GetByIdAsync(string id);
    Task UpdateAsync(string id, T entity);
    Task DeleteAsync(string id);
}
