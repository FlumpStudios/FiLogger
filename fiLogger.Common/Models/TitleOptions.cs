using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class TitleOptions
    {
        public TitleOptions()
        {
            CustomerDetails = new HashSet<CustomerDetails>();
        }

        [Key]
        public int TitleId { get; set; }

        [MaxLength(30)]
        public string TitleName { get; set; }

        public ICollection<CustomerDetails> CustomerDetails { get; set; }
    }
}
