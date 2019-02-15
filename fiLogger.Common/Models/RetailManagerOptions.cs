using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class RetailManagerOptions
    {
        public RetailManagerOptions()
        {
            CustomerDetails = new HashSet<CustomerDetails>();
        }

        [Key]
        public int RetailManagerId { get; set; }

        [MaxLength(50)]
        public string RetailManagerName { get; set; }

        public ICollection<CustomerDetails> CustomerDetails { get; set; }
    }
}
