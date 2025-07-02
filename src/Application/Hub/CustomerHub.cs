using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;

public class CustomerHub : Hub
{
    // Diccionario concurrente para almacenar las conexiones (thread-safe)
    private static readonly ConcurrentDictionary<string, string> ClientConnections = new();

    // Diccionario para mapear IDs de cliente con connectionIds
    private static readonly ConcurrentDictionary<string, string> ClientToConnectionMap = new();

    /// <summary>
    /// Registra una conexión asociada a un ID de cliente
    /// </summary>
    public async Task RegisterClient(string clientId)
    {
        var connectionId = Context.ConnectionId;

        ClientConnections.TryAdd(connectionId, clientId);
        ClientToConnectionMap.TryAdd(clientId, connectionId);

        await Groups.AddToGroupAsync(connectionId, clientId);

        Console.WriteLine($"Cliente registrado: {clientId} - Conexión: {connectionId}");
    }

    /// <summary>
    /// Se ejecuta cuando un cliente se conecta
    /// </summary>
    public override async Task OnConnectedAsync()
    {
        Console.WriteLine($"Nueva conexión: {Context.ConnectionId}");
        await base.OnConnectedAsync();
    }

    /// <summary>
    /// Se ejecuta cuando un cliente se desconecta
    /// </summary>
    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        if (ClientConnections.TryRemove(Context.ConnectionId, out var clientId))
        {
            ClientToConnectionMap.TryRemove(clientId, out _);
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, clientId);

            Console.WriteLine($"Cliente desconectado: {clientId} - Conexión: {Context.ConnectionId}");
        }

        await base.OnDisconnectedAsync(exception);
    }

    /// <summary>
    /// Notifica a un cliente específico
    /// </summary>
    public async Task NotifyClient(string clientId, string messageType, object payload)
    {
        if (ClientToConnectionMap.TryGetValue(clientId, out var connectionId))
        {
            await Clients.Client(connectionId).SendAsync(messageType, payload);
            Console.WriteLine($"Notificación enviada a {clientId}: {messageType}");
        }
        else
        {
            Console.WriteLine($"Cliente {clientId} no encontrado para notificación");
            // Opcional: Implementar cola de mensajes pendientes para cuando el cliente se reconecte
        }
    }

    /// <summary>
    /// Notifica a un grupo de clientes
    /// </summary>
    public async Task NotifyGroup(string groupName, string messageType, object payload)
    {
        await Clients.Group(groupName).SendAsync(messageType, payload);
        Console.WriteLine($"Notificación enviada al grupo {groupName}: {messageType}");
    }
}