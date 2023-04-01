using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Entities.Club
{
    [Table("ClubStatus")]
    public class ClubStatus
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ClubId { get; set; }

        public bool IsActive { get; set; }

        public Guid DeletedBy { get; set; }

        public DateTime DeletedOn { get; set; }

        public Guid ReactivatedBy { get; set; }

        public DateTime ReactivatedOn { get; set; }

        public Guid DeactivatedBy { get; set; }

        public DateTime DeactivatedOn { get; set; }

        public bool IsReported { get; set; }

        public Guid ReportedBy { get; set; }

        public DateTime ReportedOn { get; set; }

        public string? Reason { get; set; }
    }
}
