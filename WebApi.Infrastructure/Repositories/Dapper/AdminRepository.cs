using AutoMapper;
using Dapper;
using Dapper.Contrib.Extensions;
using WebApi.Domain.Data;
using WebApi.Domain.ViewModels.Clubs;
using WebApi.Domain.ViewModels.Users;
using WebApi.Infrastructure.Interfaces;

namespace WebApi.Infrastructure.Repositories.Dapper
{
    public class AdminRepository : IAdminRepository
    {
        private DbContext _db;
        public AdminRepository(DbContext db)
        {
            _db = db;
        }
        public IEnumerable<InActiveClub> GetInActiveClubs()
        {
            var query = "Select Id, Name, ClubType, Description, CreatedBy, CreatedOn, Reason, DeactivatedBy, DeactiavtedOn from ClubDetailsView where IsActive = 0";
            return _db.connection.Query<InActiveClub>(query);
        }
        public IEnumerable<UserProfile> GetAllUsers()
        {
            var query = "Select Id,DisplayName,Email,Phone,UserAccess,AddedBy,AddedOn,count(*) as ActiveClubs from AllUsersView where IsActive = 1 group by Id,DisplayName,Email,Phone,UserAccess,AddedBy,AddedOn";
            return _db.connection.Query<UserProfile>(query);
        }
        public IEnumerable<AvailableClubs> GetAvailableClubs()
        {
            var query = "Select Id,Name,ProfilePicture from ClubDetailsView where IsActive = 1 and ClubType!= 3";
            return _db.connection.Query<AvailableClubs>(query);
        }
       /* public void UpdateClubActivationStatus(ActionUpdater action)
        {

        }
        public UserStatus UpdateUserActivationStatus(ActionUpdater action)
        {

        }
        public void Delete(ActionUpdater action)
        {

        }*/
        public Guid AddNewUser(User newUser)
        {
            var sql = "Insert into Users(FirstName, MiddleName, LastName, Email, Phone, DisplayName, UserAccess, AddedBy, AddedOn, JobTitle) OUTPUT Inserted.Id values (@firstname, @middlename, @lastname, @email, @phone, @displayname, @userstatus, @AdminId, @AddedOn, @JobTitle)";
            return _db.connection.QuerySingle<Guid>(sql, newUser);

        }
    }
}

