namespace WebApi.Application.DTO.Chats
{
    public class MessageDTO
    {
        public Guid SenderId { get; set; }

        public Guid ReceverId { get; set; }
        public string? SenderName { get; set; }

        public string? SenderProfilePicture { get; set; }

        public string? MessageBody { get; set; }

        public bool MessageBodyType { get; set; }

        public string[]? MessageAttachment { get; set; }

        public DateTime MessageTime { get; set; }
    }
}
