using WebApi1.Application.DTO;

namespace WebApi1.Interfaces
{
    public interface IClubCalls
    {
        public IEnumerable<AllClubs> GetAllClubs(Guid UserId);
        public void ReportClub(Guid ClubId);
        public void EditClubInformation(EditClubInformation ClubInformation);
        public void UpdateClubType(Guid UserId, Guid ClubId,int Clubtype);
        public void CreateAClub(Club club);
        public void CancelClubRequest(Guid ClubId, Guid UserId);
        public void JoinClub(Guid userId, Guid clubId);
    }
    
}
