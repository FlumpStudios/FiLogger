using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class ProductsAndServicesStatusOptions
    {
        public ProductsAndServicesStatusOptions()
        {
            CustomerProducts = new HashSet<CustomerProducts>();
        }

        [Key]
        public int ProductsStatusId { get; set; }

        [MaxLength(50)]
        public string ProductStatus { get; set; }

        public ICollection<CustomerProducts> CustomerProducts { get; set; }
    }
}
