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
       /* public IEnumerable<InActiveClub> GetInActiveClubs()
        {
           return _db.connection.Get<InActiveClubView>();
        }
        public IEnumerable<UserProfile> GetAllUsers()
        {
            return _db.connection.Get<AllUsersView>();
        }
        public IEnumerable<AvailableClubs> GetAvailableClubs()
        {
            return _db.connection.Get<AvailableClubsView>();
        }
        public void UpdateClubActivationStatus(Action action)
        {

        }
        public void DeleteClub(Action action)
        {

        }
        public UserStatus UpdateUserActivationStatus(Action action)
        {

        }
        public void DeleteUser(Action action)
        {
            _db
        }*/
        public Guid AddNewUser(User newUser)
        {
            var sql = "Insert into Users(FirstName, MiddleName, LastName, Email, Phone, DisplayName, UserAccess, AddedBy, JobTitle) OUTPUT Inserted.Id values (@firstname, @middlename, @lastname, @email, @phone, @displayname, @userstatus, @AdminId, @JobTitle)";
            return _db.connection.QuerySingle<Guid>(sql, newUser);

        }
    }
}

