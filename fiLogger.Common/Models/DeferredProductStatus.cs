using System;
using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class DeferredProductStatus
    {
        [Key]
        public int DeferredProductId { get; set; }
        public int CustomerId { get; set; }
        public DateTime? PresentationDate { get; set; }
        public bool PresentedToCustomer { get; set; }
        public int ProductId { get; set; }

        public CustomerDetails Customer { get; set; }
        public ProductsAndServicesOptions Product { get; set; }
    }
}
