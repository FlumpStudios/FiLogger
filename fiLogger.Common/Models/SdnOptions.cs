using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{    
    public class SdnOptions
    {
        [Key]
        public int SdnId { get; set; }
        public int CustomerId { get; set; }
        public bool IsCommercial { get; set; }
        public bool IsPrivateHire { get; set; }
        public bool IsFullyComp { get; set; }
        public bool IsFullyInsured { get; set; }
        public bool IsLeisure { get; set; }

        public CustomerDetails Customer { get; set; }
    }
}
