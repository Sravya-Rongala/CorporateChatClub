using Dapper;
using System.Data;
using WebApi.Application.DTO.Users;
using WebApi.Domain.Data;
using WebApi.Domain.ViewModels.Users;
using WebApi.Infrastructure.Interfaces;

namespace WebApi.Infrastructure.Repositories.Dapper
{
    public class UserRepository : IUserRepository
    {
        private DbContext _db;
        private IDbConnection connection;

        public UserRepository(DbContext db) 
        {
            this._db = db;
            this.connection = this._db.CreateConnection();
        }

        public bool IsUserExist(Guid UserId)
        {
            var query = "SELECT 1 FROM Users WHERE Id = @UserId";
            return this.connection.QueryFirstOrDefault<bool>(query, new {UserId});
        }

        public UserInformation GetUserInformation(Guid UserId)
        {
            var query = "Select * From UserInformationView Where Id = @UserId";
            return this.connection.QueryFirstOrDefault<UserInformation>(query, new { UserId });
        }

        public bool UpdateProfilePicture(Guid UserId, string picture)
        {
            var query = "UPDATE Users set ProfilePicture = @picture  where Id = @UserId ";
            int noOfRowsAffected = this.connection.Execute(query, new { UserId, picture });
            return noOfRowsAffected > 0;
        }

        public bool UpdatePersonalDetails(Guid UserId,UserPersonalDetails PersonalDetails)
        {
            var query = $"UPDATE Users set FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, DisplayName = @DisplayName, Gender = @Gender, MaritalStatus = @MaritalStatus, BloodGroup = @BloodGroup, DateOfBirth = @DateOfBirth , About = @About where Id = '{UserId}' ";
            int noOfRowsAffected = this.connection.Execute(query, PersonalDetails);
            return noOfRowsAffected > 0;    
        }

        public bool UpdateUserSummary(Guid UserId,string userSummary)
        {
            var query = "UPDATE Users set Summary = @userSummary  where Id = @UserId";
            int noOfRowsAffected = this.connection.Execute(query, new { userSummary, UserId } );
            return noOfRowsAffected > 0;
        }

        public Guid GetAddressId(Guid UserId)
        {
            var query = "Select Id from Address where UserId = @UserId";
            return this.connection.QueryFirstOrDefault<Guid>(query, new { UserId });
        }

        public int UpdateAddressDetails(Guid AddressId, UserContactDetails AddressDetails)
        {
            var query =  $"UPDATE Address set Line1 = @Line1, Line2 = @Line2, City = @City, State = @State, ZipCode = @ZipCode where Id = '{AddressId}'";
            int noOfRowsAffected  = this.connection.Execute(query, AddressDetails );
            return noOfRowsAffected;
        }

        public bool UpdateContactDetails(Guid UserId,UserContactDetails contactDetails)
        {
            var query = $"UPDATE Users set Phone = @Phone, Email = @Email where Id = '{UserId}'";
            int noOfRowsAffected = this.connection.Execute(query,contactDetails);
            Guid AddressId = this.GetAddressId(UserId);
            noOfRowsAffected = noOfRowsAffected +  this.UpdateAddressDetails(AddressId, contactDetails);  
            return noOfRowsAffected == 2;
        }

    }
}
