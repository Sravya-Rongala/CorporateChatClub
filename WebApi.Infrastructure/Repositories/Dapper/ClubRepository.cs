using Dapper;
using System.Data;
using WebApi.Domain.Data;
using WebApi.Domain.ViewModels;
using WebApi.Domain.ViewModels.Clubs;
using WebApi.Infrastructure.Interfaces;

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

        public bool IsClubExist(Guid ClubId)
        {
            var query = "SELECT 1 FROM Club WHERE Id = @ClubId";
            return this.connection.QueryFirstOrDefault<bool>(query, new { ClubId });
        }

        public IEnumerable<ClubProfile> GetAllClubs(Guid UserId)
        {
            var query = " Select * from AllClubsView where UserID = @UserId";
            return this.connection.Query<ClubProfile>(query, new { UserId });
        }

        public bool ReportClub(Guid UserId, ActionUpdater action)
        {
            action.ActionTakenOn = DateTime.Now;
            var query = $"Update UserClubAction set Reason = @Reason, IsReported = 1, ReportedOn = @ActionTakenOn where ClubId = @ActionTargetId and UserId = '{UserId}' ";
            int noOfRowsAffected = this.connection.Execute(query, action);
            return noOfRowsAffected > 0;
        }

        public bool UpdateClubInformation(Guid UserId, ClubInformation ClubInformation)
        {
            var query = "Update Club set Name = @ClubName, ProfilePicture = @ClubProfilePicture, Description = @ClubDescription where Id = @ClubId";
            int noOfRowsAffected = this.connection.Execute(query, ClubInformation);
            return noOfRowsAffected > 0;

        }

        public bool UpdateClubType(Guid UserId, Guid ClubId, int ClubType)
        {
            var query = $"Update Club set ClubType = '{ClubType}' where Id = '{ClubId}'";
            int noOfRowsAffected = this.connection.Execute(query);
            return noOfRowsAffected > 0;
        }

        public Guid AddClub(Guid UserId, Club club)
        {
            var query = $"Insert into Club(Name,Description,ProfilePicture,ClubType,ClubCreatedBy) OUTPUT Inserted.Id values (@Name,@Description,@ProfilePicture,@ClubType,'{UserId}') ";
            return this.connection.QuerySingle<Guid>(query, club);
        }

        public bool CancelClubRequest(Guid UserId, Guid ClubId)
        {
            var query = $"Update ClubRequest set RequestStatus = 3 where ClubId = '{ClubId}' and RequestedBy = '{UserId}'";
            int result = this.connection.Execute(query);
            return result > 0;
        }

        public void JoinClub(Guid UserId, Guid ClubId, int ClubType)
        {
            if (ClubType == 1)
            {
                this.AddUserToClub(UserId, ClubId, UserId,3);
                this.AddUserDataToClubAction(UserId, ClubId);
            }
            else
            {
                this.RequestClubToJoin(UserId, ClubId);
            }
        }

        public void RequestClubToJoin(Guid UserId, Guid ClubId)
        {
            var query = $"Insert into ClubRequest(ClubId,RequestedBy) values('{ClubId}','{UserId}')";
            this.connection.Execute(query);
        }

        public void AddUserToClub(Guid UserId, Guid ClubId, Guid AddedBy,int Role)
        {
            var query = $"Insert into ClubMember(UserId,ClubId,AddedBy,Role) values('{UserId}','{ClubId}','{AddedBy}','{Role}')";
            this.connection.Execute(query);
        }

        public void AddUserDataToClubAction(Guid UserId, Guid ClubId)
        {
            var query = $"Insert into UserClubAction(UserId,ClubId) values ('{UserId}','{ClubId}')";
            this.connection.Execute(query);
        }

        public void AddClubToClubStatus(Guid ClubId)
        {
            var query = $"Insert into ClubStatus(ClubId) values ('{ClubId}')";
            this.connection.Execute(query);
        }

    }
}