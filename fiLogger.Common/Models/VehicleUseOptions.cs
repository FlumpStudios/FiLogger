using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class VehicleUseOptions
    {
        public VehicleUseOptions()
        {
            VehicleDetails = new HashSet<VehicleDetails>();
        }

        [Key]
        public int VehicleUseId { get; set; }

        [MaxLength(50)]
        public string VehicleUseName { get; set; }

        public ICollection<VehicleDetails> VehicleDetails { get; set; }
    }
}
