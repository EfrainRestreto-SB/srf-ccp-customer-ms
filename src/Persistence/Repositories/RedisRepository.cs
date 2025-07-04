using StackExchange.Redis;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using Persistence.Repositories.Redis.Interfaces;

namespace Persistence.Repositories.Redis;

public class RedisRepository : IRedisRepository
{
    private readonly IDatabase _database;
    private readonly ILogger<RedisRepository> _logger;

    public RedisRepository(IConnectionMultiplexer redis, ILogger<RedisRepository> logger)
    {
        _database = redis.GetDatabase();
        _logger = logger;
    }

    public async Task SetAsync<T>(string key, T value, TimeSpan? expiry = null)
    {
        try
        {
            string json = JsonSerializer.Serialize(value);
            await _database.StringSetAsync(key, json, expiry);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error setting Redis key: {Key}", key);
        }
    }

    public async Task<T?> GetAsync<T>(string key)
    {
        try
        {
            RedisValue value = await _database.StringGetAsync(key);
            return value.HasValue
                ? JsonSerializer.Deserialize<T>(value!)
                : default;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting Redis key: {Key}", key);
            return default;
        }
    }

    public async Task<bool> ExistsAsync(string key)
    {
        return await _database.KeyExistsAsync(key);
    }

    public async Task DeleteAsync(string key)
    {
        try
        {
            await _database.KeyDeleteAsync(key);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error deleting Redis key: {Key}", key);
        }
    }
}
