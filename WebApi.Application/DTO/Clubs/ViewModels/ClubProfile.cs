namespace WebApi.Application.DTO.Clubs.ViewModels
{
    public class ClubProfile
    {
        public Guid ClubId { get; set; }

        public string? ClubName { get; set; }

        public string? ClubDescription { get; set; }

        public Guid ClubCreatedBy { get; set; }

        public DateTime ClubCreatedOn { get; set; }

        public int ClubParticipantsCount { get; set; }

        public string? ClubProfilePicture { get; set; }

        public string? ClubType { get; set; }

        public bool isClubMember { get; set; }

        public bool isRequested { get; set; }


    }
}
