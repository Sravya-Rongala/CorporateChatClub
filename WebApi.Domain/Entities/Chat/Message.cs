using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Entities.Chat
{
    [Table("Message")]
    public class Message
    {
        [Key]
        public Guid Id { get; set; }

        public Guid SenderId { get; set; }

        public Guid ReceiverId { get; set; }

        public string? Body { get; set; }

        public string[]? Attachment { get; set; }

        public DateTime? SentTime { get; set; }

        public bool? IsSeen { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? CreatedOn { get;set; }

        public string? ModifiedBy { get; set; } 
        public DateTime? ModifiedOn { get;set; }

    }
}
