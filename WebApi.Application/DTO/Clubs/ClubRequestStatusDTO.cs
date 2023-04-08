namespace WebApi.Application.DTO.Clubs
{
    public class ClubRequestStatusDTO
    {
        public Guid RequestedUserId { get; set; }

        public Guid ClubId { get; set; }

        public int RequestStatus { get; set; }
    }
}
