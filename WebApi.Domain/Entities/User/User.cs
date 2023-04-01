using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Entities.User
{
    [Table("User")]

    public class User
    {
        [Key]
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public Guid AddressId { get; set; }

        public string? DisplayName { get; set; }

        public int Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int MaritalStatus { get; set; }

        public int BloodGroup { get; set; }

        public string? About { get; set; }

        public string? Summary { get; set; }

        public string? ProfilePicture { get; set; }

        public Guid RoleId { get; set; }

        public string? UserAccess { get; set; }
    }
}
