namespace WebApi.Application.DTO.Connections
{
    public class SuggestedConnectionDTO
    {
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public string ProfilePicture { get; set; }

        public int MutualClubsCount { get; set; }

        public int MutualConnectionsCount { get; set; }
    }
}
