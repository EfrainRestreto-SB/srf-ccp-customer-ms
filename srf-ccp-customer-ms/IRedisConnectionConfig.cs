namespace Core.Interfaces.Configuration
{
    public interface IRedisConnectionConfig
    {
        string ConnectionString { get; }
    }
}
