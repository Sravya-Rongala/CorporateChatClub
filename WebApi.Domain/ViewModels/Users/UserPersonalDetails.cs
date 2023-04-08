namespace WebApi.Domain.ViewModels.Users
{
    public class UserPersonalDetails
    {
        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }
        public string? LastName { get; set; }

        public string? DisplayName { get; set; }

        public int Gender { get; set; }

        public int MaritalStatus { get; set; }

        public int BloodGroup { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string? About { get; set; }

    }
}
