namespace Application.Utils;

public static class ResponseBuilder
{
    public static object BuildAcceptedResponse(string id, string message = "Solicitud en proceso")
    {
        return new
        {
            id,
            mensaje = message,
            estado = "Pendiente"
        };
    }

    public static object BuildNotFoundResponse(string id, string message = "Recurso no encontrado")
    {
        return new
        {
            id,
            mensaje = message,
            estado = "No encontrado"
        };
    }

    public static object BuildSuccessResponse<T>(T data)
    {
        return new
        {
            estado = "Exitoso",
            data
        };
    }
}
