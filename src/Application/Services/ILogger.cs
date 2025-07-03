namespace Application.Services
{
    internal interface ILogger<T>
    {
        void LogInformation(string v, string clientId);
        void LogWarning(string v);
    }
}