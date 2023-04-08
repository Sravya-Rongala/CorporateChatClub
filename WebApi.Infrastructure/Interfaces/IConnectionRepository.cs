using WebApi.Domain.ViewModels.Chats;
using WebApi.Domain.ViewModels.Connections;

namespace WebApi.Infrastructure.Interfaces
{
    public  interface IConnectionRepository
    {
        public IEnumerable<Chat> GetAllUserChats(Guid UserId);
        public ChatInformation GetChatInformation(Guid UserId, Guid ConnectedUserId);
        public IEnumerable<Message> GetChatMessages(Guid ConnectedUserId);
        public IEnumerable<SuggestedConnection> GetSuggestedConnections(Guid UserId);
        public PendingConnection GetPendingConnection(Guid UserId, Guid RequestedUserId);
        public int GetUnseenConnectionCount(Guid UserId);
        public void SendConnectionRequest(Guid UserId, Guid RequestedUserId);
    }
}
