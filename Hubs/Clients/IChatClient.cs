using SignalRChat.Models;
using System.Threading.Tasks;
namespace SignalRChat.Hubs.Clients
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}