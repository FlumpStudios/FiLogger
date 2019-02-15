using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class DeferredSalesStatus
    {
        public DeferredSalesStatus()
        {
            CustomerDetails = new HashSet<CustomerDetails>();
        }

        [Key]
        public int DeferredSalesStatusId { get; set; }

        [MaxLength(50)]
        public string DeferredSalesStatusValue { get; set; }

        public ICollection<CustomerDetails> CustomerDetails { get; set; }
    }
}
