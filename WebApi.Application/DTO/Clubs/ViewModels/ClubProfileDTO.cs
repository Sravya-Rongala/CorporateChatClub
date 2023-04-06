namespace WebApi.Application.DTO.Clubs.ViewModels
{
    public class ClubProfileDTO
    {
        public Guid ClubId { get; set; }

        public string? ClubName { get; set; }

        public string? Description { get; set; }

        public string? ClubCreatedBy { get; set; }

        public DateTime ClubCreatedOn { get; set; }

        public int ClubParticipantsCount { get; set; }

        public string? ClubProfilePicture { get; set; }

        public string? ClubType { get; set; }

        public bool IsClubMember { get; set; }

        public bool IsRequested { get; set; }
    }
}
