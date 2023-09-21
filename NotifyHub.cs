using Microsoft.AspNetCore.SignalR;

namespace codebefore.socket.api
{
    public class NotifyHub : Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("message", message);
        }
    }
}
