using Microsoft.AspNetCore.SignalR;

namespace SignalRChatRoomApp.Hubs
{
    public class ChatHub : Hub
    {
        private readonly string _botUser;
        public ChatHub()
        {
            _botUser = "MyChat bot";
        }
        public async Task JoinRoom(UserConnection userConnection)
        {
            await Clients.All.SendAsync("ReceieveMessage", "Hey everyone");
        }
    }
}
