namespace Core.Config.SettingFiles.Redis;

public class RedisJson
{
    public string? Host { get; set; }
    public string? Port { get; set; }
    public string? User { get; set; }
    public string? Password { get; set; }
    public string? SslHost { get; set; }
    public int? MaxMessages { get; set; }
    public string? Ssl { get; set; }
}
