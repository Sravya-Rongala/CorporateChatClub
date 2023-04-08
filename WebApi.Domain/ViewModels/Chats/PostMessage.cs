namespace WebApi.Domain.ViewModels.Chats
{
    public class PostMessage
    {
        public Guid ReceiverId { get; set; }

        public string? MessageBody { get; set; }

        public string[]? MessageAttachement { get; set; }

        public bool IsClub { get; set; }


    }
}
