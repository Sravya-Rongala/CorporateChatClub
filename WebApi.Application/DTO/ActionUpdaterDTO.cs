namespace WebApi.Application.DTO
{
   public class ActionUpdaterDTO
    {
        public Guid ActionTakenBy { get; set; }
        public Guid ActionTargetId { get; set; }    
        public string? Reason { get; set; }
        public bool IsClub { get; set; }

    }
}
