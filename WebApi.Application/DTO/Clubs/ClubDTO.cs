using WebApi.Application.DTO.Users;

namespace WebApi.Application.DTO.Clubs
{
    public class ClubDTO
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? ProfilePicture { get; set; }

        public int ClubType { get; set; }

        public List<SuggestedUserDTO>? ClubAdmins { get; set; }

        public List<SuggestedUserDTO>? ClubMembers { get; set; }
    }
}