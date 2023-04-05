using WebApi.Application.DTO;
using WebApi.Application.DTO.Clubs;
using WebApi.Application.DTO.Clubs.ViewModels;

namespace WebApi.Interfaces
{
    public interface IClubService
    {
        public IEnumerable<ClubProfileDTO> GetAllClubs(Guid UserId);
        public bool ReportClub(Guid UserId, ActionUpdaterDTO action);
        public bool UpdateClubInformation(Guid UserId, ClubInformationDTO ClubInformation);
        public bool UpdateClubType(Guid UserId, Guid ClubId, int ClubType);
        public Guid CreateClub(Guid UserId, ClubDTO club);
        public bool CancelClubRequest(Guid UserId, Guid ClubId);
        public void JoinClub(Guid UserId, Guid ClubId);
    }
}