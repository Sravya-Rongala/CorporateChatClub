namespace WebApi.Domain.ViewModels.Clubs
{
    public class ClubRequestStatus
    {
        public Guid RequestedUserId { get; set; }

        public Guid ClubId { get; set; }

        public int RequestStatus { get; set; }
    }
}
