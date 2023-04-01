using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Entities.Club
{
    [Table("Club")]
    public class Club
    {
        [Key]
        public Guid Id { get; set; }

        public string? Name { get; set; }
        public int ClubType { get; set; }
        public string? Description { get; set; }

        public string? ProfilePicture { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
