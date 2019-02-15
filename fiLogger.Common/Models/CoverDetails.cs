using System;
using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class CoverDetails
    {
        [Key]
        public int CoverDetailsId { get; set; }
        public decimal RetailPrice { get; set; }
        public DateTime? PresentationDate { get; set; }
        public DateTime? CoverStartDate { get; set; }
        public bool IsProductOnMainOrder { get; set; }
        public DateTime? TreatmentDate { get; set; }
        [MaxLength(30)]
        public string UniqueReference { get; set; }
        public int PolicyDurationId { get; set; }
        public int PolicyClaimLimitId { get; set; }
        public int ProductId { get; set; }

        public PolicyClaimLimitOptions PolicyClaimLimit { get; set; }
        public PolicyDurationOptions PolicyDuration { get; set; }
        public ProductsAndServicesOptions Product { get; set; }
    }
}
