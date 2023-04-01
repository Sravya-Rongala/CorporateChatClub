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
        public string? Privelege { get; set; }
    }
}
