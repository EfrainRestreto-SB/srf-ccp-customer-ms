using StackExchange.Redis;

namespace Domain.Interfaces.Repositories;

public interface IRedisRepository
{
    public Task StoreSet(string key, string value);
    public Task<RedisValue[]>? GetallSetListItems(string key);
    public Task<string?> GetValueByPattern(string keySet, string pattern);
}
