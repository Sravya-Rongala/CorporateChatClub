using WebApi1.Application.DTO;
namespace WebApi1.Interfaces
{
    public interface IHomeCalls
    {
        public IEnumerable<UserClub> GetAllUserClubs(Guid UserId);
        public ClubInformation GetUserClubInformation(Guid ClubId);
        public IEnumerable<SuggestedUser> GetSuggestedUsers(Guid ClubId);
        public void MakeFavouriteClub(Guid UserId, Guid ClubId); public void ExitClub(Guid UserId, Guid ClubId);
        public void MuteClub(Guid UserId, Guid ClubId);
        public Message SendMessage(Message message);
        public void AddParticipantsToClub(List<Guid> UserId);
        public void RemoveAsAdmin(UserAction userAction);
        public void BlockAParticipant(UserAction userAction);
    }
}
