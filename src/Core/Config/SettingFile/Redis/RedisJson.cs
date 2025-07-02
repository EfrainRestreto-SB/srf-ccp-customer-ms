namespace Core.Config.SettingFiles.Redis;

public class RedisJson
{
    public string? Host { get; set; }
    public int Port { get; set; }
    public string? Password { get; set; }
    public int Database { get; set; }
    public bool Ssl { get; set; }
}
