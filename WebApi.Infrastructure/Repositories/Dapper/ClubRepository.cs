using WebApi.Domain.ViewModels.Clubs;
using WebApi.Domain.ViewModels;
using WebApi.Infrastructure.Interfaces;
using System.Data;
using WebApi.Domain.Data;

namespace WebApi.Infrastructure.Repositories.Dapper
{
    public class ClubRepository : IClubRepository
    {
        private DbContext _db;
        private IDbConnection connection;

        public ClubRepository(DbContext db)
        {
            this._db = db;
            this.connection = this._db.CreateConnection();
        }

        public IEnumerable<ClubProfile> GetAllClubs(Guid UserId)
        {

        }
        public bool ReportClub(Guid UserId, ActionUpdater action)
        {

        }
        public bool UpdateClubInformation(Guid UserId, ClubInformation ClubInformation)
        {

        }
        public bool UpdateClubType(Guid UserId, Guid ClubId, int ClubType)
        {

        }
        public Guid CreateClub(Guid UserId, Club club)
        {

        }
        public bool CancelClubRequest(Guid UserId, Guid ClubId)
        {

        }
        public void JoinClub(Guid UserId, Guid ClubId)
        {

        }
    }
}