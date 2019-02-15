using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class FinanceDetails
    {
        [Key]
        public int FinanceDetailsId { get; set; }
        public int FinanceTypeId { get; set; }
        public int FinanceCompanyId { get; set; }
        public decimal FinalPaymentAmount { get; set; }
        public decimal AmountFinanced { get; set; }
        public byte FinanceTermMonths { get; set; }
        public int ContractedMilage { get; set; }
        public int AnticipatedMilage { get; set; }
        public int ProductId { get; set; }

        public FinanceCompanyOptions FinanceCompany { get; set; }
        public FinanceTypeOptions FinanceType { get; set; }
        public ProductsAndServicesOptions Product { get; set; }
    }
}
