namespace WebApi.Application.DTO.Users
{
    public class UserContactDetails
    {
        public Guid UserId { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
    }
}
