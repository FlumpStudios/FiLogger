using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class PolicyStatusOptions
    {
        public PolicyStatusOptions()
        {
            CustomerDetails = new HashSet<CustomerDetails>();
        }

        [Key]
        public int PolicyStatusId { get; set; }

        [MaxLength(50)]
        public string PolicyStatus { get; set; }

        public ICollection<CustomerDetails> CustomerDetails { get; set; }
    }
}
