using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class ProductsAndServicesOptions
    {
        public ProductsAndServicesOptions()
        {
            CoverDetails = new HashSet<CoverDetails>();
            CustomerProducts = new HashSet<CustomerProducts>();
            DeferredProductStatus = new HashSet<DeferredProductStatus>();
            FinanceDetails = new HashSet<FinanceDetails>();
            PolicyType = new HashSet<PolicyType>();
        }

        [Key]
        public int ProductId { get; set; }

        [MaxLength(50)]
        public string ProductName { get; set; }
        public int ProductTypeId { get; set; }
        public bool IsDeferredProduct { get; set; }

        public ProductTypeOptions ProductType { get; set; }
        public ICollection<CoverDetails> CoverDetails { get; set; }
        public ICollection<CustomerProducts> CustomerProducts { get; set; }
        public ICollection<DeferredProductStatus> DeferredProductStatus { get; set; }
        public ICollection<FinanceDetails> FinanceDetails { get; set; }
        public ICollection<PolicyType> PolicyType { get; set; }
    }
}
