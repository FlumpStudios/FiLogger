using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class VehicleTypeOptions
    {
        public VehicleTypeOptions()
        {
            VehicleDetails = new HashSet<VehicleDetails>();
        }

        [Key]
        public int VehicleTypeId { get; set; }

        [MaxLength(50)]
        public string VehicleTypeName { get; set; }

        public ICollection<VehicleDetails> VehicleDetails { get; set; }
    }
}
