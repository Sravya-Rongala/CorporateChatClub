

namespace WebApi.Application.DTO.Chats
{
    public class MessageDTO
    {
        public Guid SenderId { get; set; }

        public Guid ReceverId { get; set; }
        public string? SenderName { get; set; }

        public string? SenderProfilePicture { get; set; }

        public MessageBodyDTO? MessageBody { get; set; }

        public string[]? MessageAttachment { get; set; }

        public DateTime MessageTime { get; set; }
    }
}
