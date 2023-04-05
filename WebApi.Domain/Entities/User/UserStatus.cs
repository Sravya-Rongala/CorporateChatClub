using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Entities.User
{
    [Table("UserStatus")]
    public class UserStatus
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public bool IsActive { get; set; }
        public Guid DeactivatedBy { get; set; }
        public DateTime DeactivatedOn { get; set; }
        public Guid ReactivatedBy { get; set; }
        public DateTime ReactivatedOn { get; set; }
        public string? Reason { get; set; }
        public Guid DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
