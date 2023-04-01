namespace WebApi.Domain.ViewModels.Users
{
    public class User
    {
        public Guid AdminId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? DisplayName { get; set; }
        public int UserStatus { get; set; }
        public int RoleId { get; set; } 
        public string? JobTitle { get; set; }
        public List<Guid>? Clubs { get; set; }

    }
}
