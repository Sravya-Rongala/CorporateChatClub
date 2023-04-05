namespace WebApi.Domain.ViewModels.Clubs
{
    public class ClubInformation
    {
        public Guid ClubId { get; set; }
        public string? ClubName { get; set; }

        public string? ClubDescription { get; set; }

        public string? ClubProfilePicture { get; set; }
    }
}
