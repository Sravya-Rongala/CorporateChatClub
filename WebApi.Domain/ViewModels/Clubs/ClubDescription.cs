namespace WebApi.Application.DTO.Clubs
{
    public class ClubDescription
    {
        public string? ClubName { get; set; }
        public string? Description { get; set; }

        public int ClubType { get; set; }

        public Guid ClubCreatedBy { get; set; }

        public DateTime ClubCreatedOn { get; set; }

        public int ClubParticipantsCount { get; set; }

        public bool IsMuted { get; set; }
    }
}
