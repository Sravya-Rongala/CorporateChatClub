using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Entities.Chat
{
    [Table("UserChat")]
    public class UserChat
    {
        [Key]
        public Guid Id { get; set; }

        public Guid UserConnectionId { get; set; }

        public bool IsFavourite { get; set; }

        public bool IsMuted { get; set; }

        public bool IsBlocked { get; set; }

        public DateTime BlockedOn { get; set; }
        public string? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
