namespace WebApi.Application.DTO.Users
{
    public class User
    {
        public Guid AdminId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? DisplayName { get; set; }
        public int UserStatus { get; set; }
        public List<Guid>? Clubs { get; set; }

    }
}
