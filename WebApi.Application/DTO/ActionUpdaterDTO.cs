namespace WebApi.Application.DTO
{
   public class ActionUpdaterDTO
    {
        public Guid ActionTargetId { get; set; }    
        public string? Reason { get; set; }
        public bool IsClub { get; set; }

    }
}
