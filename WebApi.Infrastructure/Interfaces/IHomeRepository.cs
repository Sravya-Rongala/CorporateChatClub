using WebApi.Domain.ViewModels;
using WebApi.Domain.ViewModels.Chats;
using WebApi.Domain.ViewModels.Clubs;
using WebApi.Domain.ViewModels.Users;
using WebApi.Users.ViewModels.Users;

namespace WebApi.Infrastructure.Interfaces
{
    public interface IHomeRepository
    {
        public IEnumerable<Chat> GetUserClubs(Guid UserId);
        public ClubDescription GetClubDescription(Guid ClubId,Guid UserId);
        public IEnumerable<ClubParticipant> GetClubParticipants(Guid ClubId);
        public IEnumerable<ClubRequest> GetClubRequests(Guid ClubId);
        public IEnumerable<SuggestedUser> GetSuggestedUsers(Guid UserId, Guid ClubId);
        public ChatInformation GetChatInformation(Guid UserId, Guid ClubId);

        public IEnumerable<Message> GetChatMessages(Guid ClubId);
        public bool IsUserExist(Guid UserId);
        public string GetUserName(Guid UserId);
        public Guid SendMessagetoClub(Domain.Entities.Chat.Message message, Guid UserId, bool IsUpdationMessage);
        public Guid SendMessagetoUser(Domain.Entities.Chat.Message message, Guid UserId);
        public void AddUserToClub(Guid UserId, Guid ClubId, Guid AddedBy);

        public void AddUserClubAction(Guid UserId, Guid ClubId);
        public bool UpdateUserClubRequestStatus(Domain.Entities.Connection.ClubRequest clubRequestStatus, Guid UserId);
        public bool MakeFavouriteClubChat(ActionUpdater actionUpdater, Guid UserId);
        public bool MakeFavouriteUserChat(ActionUpdater actionUpdater, Guid UserId);
        public bool MuteClubChat(ActionUpdater actionUpdater, Guid UserId);

        public bool MuteUserChat(ActionUpdater actionUpdater, Guid UserId);
        public bool ExitClub(Guid UserId, Guid ClubId);

        public bool RemoveAsAdmin(UserAction userAction, Guid UserId);
        public bool BlockParticipant(UserAction userAction, Guid UserId);
    }
}