namespace WebApi.Domain.ViewModels.Chats
{
    public class ChatInformation
    {
        public Guid ChatId { get; set; }

        public string? ChatName { get; set; }

        public bool IsFavouriteChat { get; set; }

        public bool IsChatMuted { get; set; }
    }
}
