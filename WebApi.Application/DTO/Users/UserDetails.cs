namespace WebApi.Application.DTO.Users
{
    public class UserDetails
    {
        public UserBasicDetails? BasicDetails { get; set; }

        public UserPersonalDetails? PersonalDetails { get; set; }

        public UserContactDetails? ContactDetails { get; set; }

        public UserSummary? UserSummary { get; set; }

        public UserProfilePicture? UserProfilePicture { get; set; }
    }
}
