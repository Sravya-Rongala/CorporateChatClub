namespace WebApi.Domain.ViewModels.Clubs
{
    public class ClubProfile
    {
        public Guid ClubId { get; set; }

        public string? ClubName { get; set; }

        public string? Description { get; set; }

        public string? ClubCreatedBy { get; set; }

        public DateTime ClubCreatedOn { get; set; }

        public int ClubParticipantsCount { get; set; }

        public string? ClubProfilePicture { get; set; }

        public int ClubType { get; set; }

        public int Role { get; set; }

        public bool IsClubMember { get; set; }

        public bool IsRequested { get; set; }
    }
}
