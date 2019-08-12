using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace FiveRingsOnline.Hubs
{
    public class ChatHub : Hub
    {
        public async Task Send(string username, string message)
        {
            await Clients.All.SendAsync("broadcastMessage", username, message);
        }
    }
}
