using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class ProductTypeOptions
    {
        public ProductTypeOptions()
        {
            ProductsAndServicesOptions = new HashSet<ProductsAndServicesOptions>();
        }

        [Key]
        public int ProductTypeId { get; set; }

        [MaxLength(50)]
        public string ProductTypeName { get; set; }

        public ICollection<ProductsAndServicesOptions> ProductsAndServicesOptions { get; set; }
    }
}
