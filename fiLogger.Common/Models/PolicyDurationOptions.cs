using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class PolicyDurationOptions
    {
        public PolicyDurationOptions()
        {
            CoverDetails = new HashSet<CoverDetails>();
        }

        [Key]        
        public int PolicyDurationId { get; set; }

        [MaxLength(50)]
        public string PolicyDurationValue { get; set; }

        public ICollection<CoverDetails> CoverDetails { get; set; }
    }
}
