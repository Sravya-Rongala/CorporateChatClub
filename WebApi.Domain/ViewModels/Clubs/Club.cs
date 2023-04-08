using WebApi.Domain.ViewModels.Users;

namespace WebApi.Domain.ViewModels.Clubs
{
    public class Club
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? ProfilePicture { get; set; }

        public int ClubType { get; set; }

        public List<SuggestedUser>? ClubAdmins { get; set; }

        public List<SuggestedUser>? ClubMembers { get; set; }
    }
}