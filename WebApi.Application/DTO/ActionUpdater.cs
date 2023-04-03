namespace WebApi.Application.DTO
{
   public class ActionUpdater
    {
        public Guid UserId { get; set; }

        public bool IsClub { get; set; }
    
        public Guid ActionTakenBy { get; set; }

        public string? Reason { get; set; }
    }
}
