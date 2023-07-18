using Microsoft.AspNetCore.SignalR;

namespace MyChat.API.Hubs
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
            await Groups.AddToGroupAsync(Context.ConnectionId, userConnection.Room);
            await Clients.Group(userConnection.Room).SendAsync("ReceiveMessage", _botUser, $"{userConnection.User} has joined {userConnection.Room}");
        }
    }
}
