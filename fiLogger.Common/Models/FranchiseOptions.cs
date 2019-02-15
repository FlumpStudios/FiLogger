using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class FranchiseOptions
    {
        public FranchiseOptions()
        {
            CustomerDetails = new HashSet<CustomerDetails>();
        }
        [Key]
        public int FranchiseId { get; set; }

        [MaxLength(50)]
        public string FranshiseName { get; set; }

        public ICollection<CustomerDetails> CustomerDetails { get; set; }
    }
}
