using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SignalRChat.Hubs.Clients;
using SignalRChat.Models;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
        public async Task SendMessage(ChatMessage message)
        {
            await Clients.All.ReceiveMessage(message);
        }
    }
}