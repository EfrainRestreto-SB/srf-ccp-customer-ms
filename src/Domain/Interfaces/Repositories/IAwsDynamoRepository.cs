using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.Repositories
{
    public interface IAwsDynamoRepository<T>
    {
        /// <summary>
        /// Inserta o actualiza un registro en la tabla DynamoDB.
        /// </summary>
        Task SaveAsync(T item);

        /// <summary>
        /// Consulta un elemento por clave primaria.
        /// </summary>
        Task<T?> GetByIdAsync(string partitionKey, string sortKey = null);

        /// <summary>
        /// Consulta múltiples elementos según la clave de partición.
        /// </summary>
        Task<IEnumerable<T>> QueryByPartitionKeyAsync(string partitionKey);

        /// <summary>
        /// Consulta todos los registros de la tabla.
        /// </summary>
        Task<IEnumerable<T>> ScanAllAsync();
    }
}
