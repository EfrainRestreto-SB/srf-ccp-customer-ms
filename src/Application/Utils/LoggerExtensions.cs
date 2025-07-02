using Microsoft.Extensions.Logging;

namespace Application.Utils;

public static class LoggerExtensions
{
    public static void LogServiceCall(this ILogger logger, string methodName, string entityId)
    {
        logger.LogInformation("Llamando {MethodName} para entidad con ID: {EntityId}", methodName, entityId);
    }

    public static void LogServiceError(this ILogger logger, string methodName, Exception ex)
    {
        logger.LogError(ex, "Error en {MethodName}: {Message}", methodName, ex.Message);
    }
}
