namespace WebApi.Domain.ViewModels.Connections
{
    public class Connection
    {
        public Guid UserId { get; set; }

        public string? Name { get; set; }

        public string? About { get; set; }

        public int MutualCount { get; set; }

        public string? Email { get; set; }

        public string? ProfilePicture { get; set; }

        public string? PhoneNumber { get; set; }
    }
}
