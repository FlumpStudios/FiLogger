using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace FiLogger.Common.Models
{
    public class FinanceCompanyOptions
    {
        public FinanceCompanyOptions()
        {
            FinanceDetails = new HashSet<FinanceDetails>();
        }

        [Key]
        public int FinanceCompanyId { get; set; }

        [MaxLength(50)]
        public string FinanceCompanyName { get; set; }

        public ICollection<FinanceDetails> FinanceDetails { get; set; }
    }
}
