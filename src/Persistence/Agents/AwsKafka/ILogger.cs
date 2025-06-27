
namespace Persistence.Agents.AwsKafka
{
    internal interface ILogger<T>
    {
        void LogError(Exception e, string v, string message, Exception? innerException, string? stackTrace);
        void LogError(string v, object name, object topic, object partition, object offset);
        void LogError(OperationCanceledException e, string v);
        void LogInformation(string v, object name, object topic, object partition, object offset);
        void LogInformation(string v1, object name, ushort consumerNumber, string v2);
    }
}