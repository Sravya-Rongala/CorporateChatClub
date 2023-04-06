using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Entities.Club
{
    [Table("UserClubAction")]
    public class UserClubAction
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ClubId { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsMuted { get; set; }
        public bool IsExited { get; set; }
        public DateTime ExitedOn { get; set; }
        public bool IsReported { get; set; }
        public DateTime ReportedOn { get; set; }
        public string? Reason { get; set; }
        public DateTime ClubOpenedAt { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string? ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
