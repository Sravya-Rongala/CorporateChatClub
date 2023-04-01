using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApi.Domain.Entities.Chat
{
    [Table("ClubChatUpdatedLog")]
    public class ClubChatUpdateLog
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ClubId { get; set; }
        public DateTime UpdatedOn { get; set; }
        public Guid UpdatedBy { get; set; }
        public Guid MessageId { get; set; }
    }
}
