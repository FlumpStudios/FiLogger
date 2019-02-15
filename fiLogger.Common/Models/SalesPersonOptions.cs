using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class SalesPersonOptions
    {
        public SalesPersonOptions()
        {
            CustomerDetails = new HashSet<CustomerDetails>();
        }

        [Key]
        public int SalesPersonId { get; set; }

        [MaxLength(50)]
        public string SalesPersonName { get; set; }

        public ICollection<CustomerDetails> CustomerDetails { get; set; }
    }
}
