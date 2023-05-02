using Microsoft.AspNetCore.SignalR;

namespace BlazorRealTimeApp.Server.Hubs
{
    public class BroadcastHub : Hub
    {
        public async Task SendMessage()
        {
            await Clients.All.SendAsync("ReceiveMessage");
        }
    }
}
