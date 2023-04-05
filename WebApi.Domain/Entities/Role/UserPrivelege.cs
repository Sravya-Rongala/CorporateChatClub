using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Entities.Role
{
    [Table("UserPrivelege")]
    public class UserPrivelege
    {
        [Key]
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }

        public Guid UserId { get; set; }
        public string? Privelege { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
