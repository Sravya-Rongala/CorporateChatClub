namespace WebApi.Application.DTO
{
   public class Action
    {
        public Guid UserId { get; set; }
    
        public Guid ActionTakenBy { get; set; }

        public string Reason { get; set; }
    }
}
