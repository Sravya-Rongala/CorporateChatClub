namespace WebApi.Application.DTO.Chats
{
    public class ChatHistoryDTO
    {
        public ChatInformationDTO? ChatInformation { get; set; }

        public IEnumerable<MessageDTO>? Messages { get; set; }
    }
}
