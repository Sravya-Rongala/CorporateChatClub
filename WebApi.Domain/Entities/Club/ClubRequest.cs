using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApi.Domain.Entities.Club
{
    [Table("ClubRequest")]
    public class ClubRequest
    {
        [Key]

        public Guid Id { get; set; }

        public Guid ClubId { get; set; }

        public Guid RequestedBy { get; set; }

        public DateTime RequestedOn { get; set; }

        public int RequestStatus { get; set; }
    }
}
