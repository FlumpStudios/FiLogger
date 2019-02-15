using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class DistanceSellingAcknowledgementOptions
    {
        public DistanceSellingAcknowledgementOptions()
        {
            CustomerDetails = new HashSet<CustomerDetails>();
        }
        [Key]
        public int DistanceSellingId { get; set; }

        [MaxLength(50)]
        public string DistanceSellingDescription { get; set; }

        public ICollection<CustomerDetails> CustomerDetails { get; set; }
    }
}
