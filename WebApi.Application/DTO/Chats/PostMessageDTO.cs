namespace WebApi.Application.DTO.Chats
{
    public class PostMessageDTO
    {
        public Guid ReceiverId { get; set; }

        public string? MessageBody { get; set; }

        public string[]? MessageAttachement { get; set; }

        public bool IsClub { get; set; }

    }
}
