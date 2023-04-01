using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Entities.Role
{
    [Table("UserRole")]
    public class UserRole
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}
