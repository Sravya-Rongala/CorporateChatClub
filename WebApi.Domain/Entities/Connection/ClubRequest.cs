using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApi.Domain.Entities.Connection
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

        public string? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
