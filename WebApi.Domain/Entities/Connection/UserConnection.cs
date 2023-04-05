using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Entities.Connection
{
    [Table("UserConnection")]
    public class UserConnection
    {
        [Key]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid ConnectedUserId { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
