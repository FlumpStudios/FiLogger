using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class CustomerDocuments
    {
        [Key]
        public int DocumentId { get; set; }

        [MaxLength(50)]
        public string DocumentLocation { get; set; }
        public int CustomerId { get; set; }

        public CustomerDetails Customer { get; set; }
    }
}
