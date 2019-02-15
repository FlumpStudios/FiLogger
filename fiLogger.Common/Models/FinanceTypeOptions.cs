using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace FiLogger.Common.Models
{
    public class FinanceTypeOptions
    {
        public FinanceTypeOptions()
        {
            FinanceDetails = new HashSet<FinanceDetails>();
        }

        [Key]
        public int FinanceTypeId { get; set; }

        [MaxLength(50)]
        public string FinanceTypeName { get; set; }

        public ICollection<FinanceDetails> FinanceDetails { get; set; }
    }
}
