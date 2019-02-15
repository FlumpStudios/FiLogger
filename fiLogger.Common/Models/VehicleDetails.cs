using System;
using System.ComponentModel.DataAnnotations;


namespace FiLogger.Common.Models
{
    public class VehicleDetails
    {
        [Key]
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public int VehicleTypeId { get; set; }
        public bool VehicleRegAvailable { get; set; }

        [MaxLength(50)]
        public string VehicleRegistration { get; set; }

        [MaxLength(50)]
        public string Manufacturer { get; set; }

        [MaxLength(50)]
        public string Model { get; set; }

        [MaxLength(50)]
        public string Aspiration { get; set; }

        [MaxLength(50)]
        public string EngineSize { get; set; }

        [MaxLength(30)]
        public string Keyword1 { get; set; }

        [MaxLength(30)]
        public string Keyword2 { get; set; }

        [MaxLength(30)]
        public string Keyword3 { get; set; }
        public DateTime? DateRegistered { get; set; }
        public DateTime? PurchasedDate { get; set; }
        public decimal? CurrentMileage { get; set; }
        public decimal? InvoiceValue { get; set; }
        public bool IsNew { get; set; }
        public bool IsFinanced { get; set; }
        public int VehicleUseId { get; set; }

        [MaxLength(50)]
        public string StockId { get; set; }
        public DateTime? WarrantyExpires { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? MotDueDate { get; set; }

        public CustomerDetails Customer { get; set; }
        public VehicleTypeOptions VehicleType { get; set; }
        public VehicleUseOptions VehicleUse { get; set; }
    }
}
