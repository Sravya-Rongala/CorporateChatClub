using WebApi.Application.DTO.Chats;
using WebApi.Application.DTO.Connections;

namespace WebApi.Interfaces
{
    public interface IConnectionService
    {
        public IEnumerable<ChatDTO> GetAllUserChats();
        public ChatHistoryDTO GetUserChatHistory(Guid UserId, Guid ReceiverId);
        public IEnumerable<SuggestedConnectionDTO> GetSuggestedConnections(Guid UserId);
        public PendingConnectionDTO GetPendingConnection(Guid UserId, Guid RequestedUserId);
    
        public void SendConnectionRequest(Guid UserId, Guid RequestedUserId);
    }
}