using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class PolicyClaimLimitOptions
    {
        public PolicyClaimLimitOptions()
        {
            CoverDetails = new HashSet<CoverDetails>();
        }
        [Key]
        public int PolicyClaimLimitId { get; set; }

        [MaxLength(50)]
        public string PolicyClaimLimitValue { get; set; }

        public ICollection<CoverDetails> CoverDetails { get; set; }
    }
}
