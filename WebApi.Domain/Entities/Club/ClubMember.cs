using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Entities.Club
{
    [Table("ClubMember")]
    public class ClubMember
    {
        public Guid ClubId { get; set; }

        public Guid UserId { get; set; }

        public Guid AddedBy { get; set; }

        public DateTime AddedOn { get; set; }
        public Guid RemovedBy { get; set; }

        public DateTime RemovedOn { get; set; }

        public bool IsBlocked { get; set; }

        public Guid BlockedBy { get; set; }

        public int Role { get; set; }

        public bool IsActive { get; set; }

        public Guid DeactivatedBy { get; set; }

        public DateTime DeactivatedOn { get; set; }

        public Guid ReactivatedBy { get; set; }

        public DateTime ReactivatedOn { get; set; }

        public string? Reason { get; set; }

    }
}
