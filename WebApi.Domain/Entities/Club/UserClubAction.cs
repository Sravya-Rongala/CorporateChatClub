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
        public DateTime ClubOpenedAt { get; set; }
    }
}
