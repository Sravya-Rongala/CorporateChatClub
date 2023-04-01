using WebApi1.Application.DTO;
using WebApi1.Application.DTO.Chats;

namespace WebApi1.Interfaces
{
    public interface IConnectionCalls
    {
        public IEnumerable<Chat> GetAllConnections(Guid Id);
        public IEnumerable<AddUser> GetNewUsers();
        public Chat SendRequest(Guid Id, Guid RecipientId);
        public void ToggleMute(Guid Id, Guid ReceipientId);
        public void ToggleFavorite(Guid Id,Guid ReceipientId);
        public void ToggleBlock(Guid Id,Guid ReceipientId);
        public Message SendMessage(Message message);
    }
}
