using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Entities.User
{
    [Table("Users")]

    public class Users
    {
        [Key]
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? DisplayName { get; set; }

        public string? JobTitle { get; set; }

        public int Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int MaritalStatus { get; set; }

        public int BloodGroup { get; set; }

        public string? About { get; set; }

        public string? Summary { get; set; }

        public string? ProfilePicture { get; set; }

        public Guid AddedBy { get; set; }

        public DateTime AddedOn { get; set; }

        public int UserAccess { get; set; }
    }
}

 
