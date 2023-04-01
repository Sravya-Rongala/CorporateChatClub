using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Entities.User
{
    [Table("UserConnection")]
    public class UserConnection
    {
        [Key]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid ConnectedUserId { get; set; }
    }
}
