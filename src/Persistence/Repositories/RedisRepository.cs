using Microsoft.Extensions.Logging;
using StackExchange.Redis;

namespace Persistence.Repositories;

public class RedisRepository : IRedisRepository, IDisposable
{
    private readonly IDatabase _redis;
    private readonly ILogger<RedisRepository> _logger;
    private readonly IConnectionMultiplexer _connection;
    private bool _disposed;

    public RedisRepository(IConnectionMultiplexer redisConnection, ILogger<RedisRepository> logger)
    {
        _connection = redisConnection;
        _logger = logger;

        if (!_connection.IsConnected)
        {
            _logger.LogError("No se pudo establecer una conexión con Redis");
            throw new RedisConnectionException(ConnectionFailureType.UnableToConnect,
                "No se pudo establecer una conexión con Redis");
        }

        _redis = _connection.GetDatabase();
    }

    public async Task StoreSet(string key, string value)
    {
        try
        {
            await _redis.SetAddAsync(key, value);
            await _redis.KeyExpireAsync(key, TimeSpan.FromHours(24));
        }
        catch (RedisException ex)
        {
            _logger.LogError(ex, "Error de Redis. Key: {Key}, Value: {Value}", key, value);
            throw new RedisException($"Error al procesar el Set. Key: {key}", ex);
        }
    }

    // Obtener todos los elementos del set
    public async Task<RedisValue[]> GetallSetListItems(string key)
    {
        // Verificar si la clave existe antes de intentar obtener los miembros
        if (!await _redis.KeyExistsAsync(key)) return [];

        return await _redis.SetMembersAsync(key);
    }

    public async Task<string?> GetValueByPattern(string keySet, string pattern)
    {
        try
        {
            RedisValue[] allElements = await GetallSetListItems(keySet);

            foreach (RedisValue element in allElements)
            {
                string elementString = element.ToString();
                if (elementString.Contains(pattern))
                    return elementString;
            }

            return null;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al buscar valor por patrón");
            return null;
        }
    }

    // Implementación de IDisposable
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _connection?.Dispose();
            }
            _disposed = true;
        }
    }

    ~RedisRepository()
    {
        Dispose(false);
    }
}

public interface IRedisRepository
{
}