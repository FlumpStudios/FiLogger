using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class CustomerProducts
    {
        [Key]
        public int CustomerId { get; set; }

        [Key]
        public int ProductsId { get; set; }
        public int ProductStatusId { get; set; }

        public CustomerDetails Customer { get; set; }
        public ProductsAndServicesStatusOptions ProductStatus { get; set; }
        public ProductsAndServicesOptions Products { get; set; }
    }
}
