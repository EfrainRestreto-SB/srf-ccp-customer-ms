using System.Threading.Tasks;

namespace Core.Interfaces.Repositories
{
    public interface IRedisRepository<T>
    {
        /// <summary>
        /// Guarda un objeto en Redis asociado a una clave.
        /// </summary>
        /// <param name="key">Clave única</param>
        /// <param name="value">Objeto a almacenar</param>
        /// <param name="expirationInMinutes">Tiempo de expiración en minutos (opcional)</param>
        Task SetAsync(string key, T value, int? expirationInMinutes = null);

        /// <summary>
        /// Obtiene un objeto desde Redis usando la clave.
        /// </summary>
        /// <param name="key">Clave a buscar</param>
        Task<T?> GetAsync(string key);

        /// <summary>
        /// Elimina un objeto de Redis por su clave.
        /// </summary>
        /// <param name="key">Clave del objeto a eliminar</param>
        Task DeleteAsync(string key);
    }
}
