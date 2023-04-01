namespace WebApi.Application.DTO.Users
{
    public class UserAction
    {
        public Guid UserId { get; set; }
        public Guid ClubId { get; set; }
        public Guid ActionTakenBy { get; set; }
    }
}
