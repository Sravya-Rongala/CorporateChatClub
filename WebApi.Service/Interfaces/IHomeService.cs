using WebApi.Application.DTO;
using WebApi.Application.DTO.Chats;
using WebApi.Application.DTO.Clubs;
using WebApi.Application.DTO.Users;

namespace WebApi.Interfaces
{
    public interface IHomeService
    {
        public IEnumerable<ChatDTO> GetUserClubs(Guid UserId);

        public ChatHistoryDTO GetClubChatHistory(Guid UserId, Guid ClubId);
        public ClubDetailsDTO GetClubDetails(Guid ClubId,Guid UserId);
        public IEnumerable<SuggestedUserDTO> GetSuggestedUsers(Guid UserId, Guid ClubId);
        public Guid SendMessage(PostMessageDTO Message, Guid UserId);
        public void AddUsersToClub(List<Guid> UserIdList, Guid ClubId, Guid UserId);
        public bool UpdateUserClubRequestStatus(ClubRequestStatusDTO ClubRequestStatus, Guid UserId);
        public bool MakeFavouriteChat(ActionUpdaterDTO ActionUpdaterDTO, Guid UserId);
        public bool MuteChat(ActionUpdaterDTO ActionUpdaterDTO, Guid UserId);
        public bool ExitClub(Guid UserId, Guid ClubId);
        public bool RemoveAsAdmin(UserActionDTO UserAction, Guid UserId);
        public bool BlockParticipant(UserActionDTO UserAction, Guid UserId);
    }
}