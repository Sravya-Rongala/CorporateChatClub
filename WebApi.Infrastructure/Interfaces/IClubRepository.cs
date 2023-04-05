using WebApi.Domain.ViewModels;
using WebApi.Domain.ViewModels.Clubs;

namespace WebApi.Infrastructure.Interfaces
{
    public interface IClubRepository
    {
        public IEnumerable<ClubProfile> GetAllClubs(Guid UserId);
        public bool ReportClub(Guid UserId, ActionUpdater action);
        public bool UpdateClubInformation(Guid UserId, ClubInformation ClubInformation);
        public bool UpdateClubType(Guid UserId, Guid ClubId, int ClubType);
        public Guid CreateClub(Guid UserId, Club club);
        public bool CancelClubRequest(Guid UserId, Guid ClubId);
        public void JoinClub(Guid UserId, Guid ClubId);
    }
}