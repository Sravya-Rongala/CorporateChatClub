namespace WebApi.Application.DTO.Chats
{
    public class ChatDTO
    {
        public Guid  ReceiverId { get; set; }
        public string? ReceiverName { get; set; }
        public string? LastMessage { get; set; }

        public string? LastAttachment { get; set; }
        public string? LastMessageUserName { get; set; }
        public DateTime LastMessageTime { get; set; }
        public string? ProfilePicture { get; set; }
        public int UnseenMessageCount { get; set; }
        public bool IsUserFavorite { get; set; }

        public int RequestStatus { get; set; }
    }
}
