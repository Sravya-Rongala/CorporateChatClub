namespace WebApi.Domain.ViewModels
{
   public class ActionUpdater
    {
        public Guid ActionTakenBy { get; set; }

        public Guid ActionTargetId { get; set; }

        public string? Reason { get; set; }

        public bool IsClub { get; set; }

        public DateTime ActionTakenOn { get; set; }
    }
}
