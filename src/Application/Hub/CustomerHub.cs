using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Application.Hubs
{
    public class CustomerHub : Hub
    {
        /// <summary>
        /// Sends a broadcast message to all connected clients.
        /// </summary>
        public async Task BroadcastMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }

        /// <summary>
        /// Sends a message to a specific connection ID.
        /// </summary>
        public async Task SendToClient(string connectionId, string message)
        {
            await Clients.Client(connectionId).SendAsync("ReceiveMessage", message);
        }

        /// <summary>
        /// Notifies when a user connects.
        /// </summary>
        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("UserConnected", Context.ConnectionId);
            await base.OnConnectedAsync();
        }

        /// <summary>
        /// Notifies when a user disconnects.
        /// </summary>
        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            await Clients.All.SendAsync("UserDisconnected", Context.ConnectionId);
            await base.OnDisconnectedAsync(exception);
        }
    }
}
