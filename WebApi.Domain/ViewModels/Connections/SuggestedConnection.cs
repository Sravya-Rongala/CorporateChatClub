namespace WebApi.Domain.ViewModels.Connections
{
    public class SuggestedConnection
    {
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public string ProfilePicture { get; set; }

        public int MutualClubsCount { get; set; }

        public int MutualConnectionsCount { get; set; }
    }
}
