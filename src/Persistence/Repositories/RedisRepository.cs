using Core.Interfaces.Configuration;
using Core.Interfaces.Repositories;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class RedisRepository<T> : IRedisRepository<T>
    {
        private readonly IDatabase _database;
        private readonly ILogger<RedisRepository<T>> _logger;

        public RedisRepository(IRedisConnectionConfig config, ILogger<RedisRepository<T>> logger)
        {
            var redis = ConnectionMultiplexer.Connect(config.ConnectionString);
            _database = redis.GetDatabase();
            _logger = logger;
        }

        public async Task SetAsync(string key, T value, int? expirationInMinutes = null)
        {
            try
            {
                var json = JsonSerializer.Serialize(value);
                var expiry = expirationInMinutes.HasValue ? TimeSpan.FromMinutes(expirationInMinutes.Value) : (TimeSpan?)null;

                await _database.StringSetAsync(key, json, expiry);
                _logger.LogInformation($"[Redis] Guardado: {key}");
            }
            catch (Exception ex)
            {
                _logger.LogError($"[Redis] Error al guardar clave '{key}': {ex.Message}");
                throw;
            }
        }

        public async Task<T?> GetAsync(string key)
        {
            try
            {
                var value = await _database.StringGetAsync(key);
                if (value.IsNullOrEmpty)
                {
                    _logger.LogWarning($"[Redis] No se encontró clave: {key}");
                    return default;
                }

                return JsonSerializer.Deserialize<T>(value!);
            }
            catch (Exception ex)
            {
                _logger.LogError($"[Redis] Error al obtener clave '{key}': {ex.Message}");
                throw;
            }
        }

        public async Task DeleteAsync(string key)
        {
            try
            {
                await _database.KeyDeleteAsync(key);
                _logger.LogInformation($"[Redis] Eliminada clave: {key}");
            }
            catch (Exception ex)
            {
                _logger.LogError($"[Redis] Error al eliminar clave '{key}': {ex.Message}");
                throw;
            }
        }

        public interface IRedisConnectionConfig
        {
            string ConnectionString { get; }
        }
    }
}
