using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class PolicyType
    {
        [Key]
        public int PolicyId { get; set; }

        [MaxLength(50)]
        public string PolicyName { get; set; }
        public int ProductId { get; set; }

        public ProductsAndServicesOptions Product { get; set; }
    }
}
