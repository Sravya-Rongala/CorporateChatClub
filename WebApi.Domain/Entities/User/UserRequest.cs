using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Entities.User
{
    [Table("UserRequest")]
    public class UserRequest
    {
        [Key]
        public Guid Id { get; set; }
        public Guid RequestedBy { get; set; }
        public Guid RequestedTo { get; set; }
        public DateTime RequestedOn { get; set; }
        public int RequestStatus { get; set; }
    }
}
