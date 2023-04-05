using Dapper;
using System.Data;
using WebApi.Domain.Data;
using WebApi.Domain.ViewModels;
using WebApi.Domain.ViewModels.Clubs;
using WebApi.Domain.ViewModels.Users;
using WebApi.Infrastructure.Interfaces;

namespace WebApi.Infrastructure.Repositories.Dapper
{
    public class AdminRepository : IAdminRepository
    {
        private DbContext _db;
        private IDbConnection connection;
        public AdminRepository(DbContext db)
        {
            this._db = db;
            this.connection = this._db.CreateConnection();
        }
        public IEnumerable<InActiveClub> GetInActiveClubs()
        {
            var query = "Select ClubId, ClubName, ClubType, ClubDescription, ClubCreatedBy, ClubCreatedOn, Reason, DeactivatedBy, DeactivatedOn from ClubDetailsView where IsActive = 0";
            return this.connection.Query<InActiveClub>(query);

        }
        public IEnumerable<UserProfile> GetAllUsers()
        {
            var query = "Select Id,DisplayName as Name,Email,Phone,UserAccess as UserStatus,AddedBy,AddedOn,count(*) as ClubCount from AllUsersView where IsActive = 1 group by Id,DisplayName,Email,Phone,UserAccess,AddedBy,AddenOn";
            return this.connection.Query<UserProfile>(query);
        }
        public IEnumerable<AvailableClubs> GetAvailableClubs()
        {
            var query = "Select ClubId,ClubName,ClubProfilePicture from ClubDetailsView where IsActive = 1 and ClubType!= 3";
            return this.connection.Query<AvailableClubs>(query);
        }

        public void DeleteClub(ActionUpdater action)
        {
            action.ActionTakenOn = DateTime.Now;
            var query = "update ClubStatus set IsActive=0 ,DeletedBy= @actiontakenby ,DeletedOn=@actiontakenOn, Reason=@reason where ClubId=@actiontargetId ";
            this.connection.Execute(query, action);
        }

        public void DeleteUser(ActionUpdater action)
        {
            action.ActionTakenOn = DateTime.Now;
            var query = "update UserStatus set IsActive=0 ,DeletedBy= @actiontakenby ,DeletedOn=@actiontakenOn, Reason=@reason where UserId=@actiontargetId ";
            this.connection.Execute(query, action);
        }
        public void UpdateClubActivationStatus(ActionUpdater action)
        {
            action.ActionTakenOn = DateTime.Now;
            var query1 = "select IsActive from ClubStatus where ClubId=@actiontargetId";
            var query2 = "";
            var isActive = this.connection.QuerySingle(query1, new { actiontargetId = action.ActionTargetId });
            if (isActive.IsActive)
            {
                query2 = "update ClubStatus set IsActive=0,DeactivatedBy=@actiontakenby,DeactivatedOn=@actiontakenon,Reason=@reason where ClubId=@actiontargetId";
            }
            else
            {
                query2 = "update ClubStatus set IsActive=1,ReactivedBy=@actiontakenby,ReactivatedOn=@actiontakenon,Reason=@reason where ClubId=@actiontargetId";
            }
            this.connection.Execute(query2, action);


        }
        public void UpdateUserActivationStatus(ActionUpdater action)
        {
            action.ActionTakenOn = DateTime.Now;
            var query1 = "select IsActive from UserStatus where UserId=@actiontargetId";
            var query2 = "";
            var isActive = this.connection.QuerySingle(query1, new { actiontargetId = action.ActionTargetId });
            if (isActive.IsActive)
            {
                query2 = "update UserStatus set IsActive=0,DeactivatedBy=@actiontakenby,DeactivatedOn=@actiontakenon,Reason=@reason where UserId=@actiontargetId";
            }
            else
            {
                query2 = "update UserStatus set IsActive=1,ReactivatedBy=@actiontakenby,ReactivatedOn=@actiontakenon,Reason=@reason where UserId=@actiontargetId";
            }
            this.connection.Execute(query2, action);

        }
        public Guid AddNewUser(User newUser)
        {
            var sql = "Insert into Users(FirstName, MiddleName, LastName, Email, Phone, DisplayName, UserAccess, AddedBy, JobTitle) OUTPUT Inserted.Id values (@firstname, @middlename, @lastname, @email, @phone, @displayname, @userstatus, @AdminId, @JobTitle)";
            return this.connection.QuerySingle<Guid>(sql, newUser);
        }
    }
}