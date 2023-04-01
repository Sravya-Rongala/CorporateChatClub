namespace WebApi.Application.DTO.Clubs
{
    public class ClubParticipant
    {
        public Guid ParticipantId { get; set; }
        public string? ParticipantName { get; set; }

        public string? ParticipantEmail { get; set; }

        public int ParticipantRole { get; set; }

        public bool IsActive { get; set; }

        public bool IsBlocked { get; set; }


    }
}
