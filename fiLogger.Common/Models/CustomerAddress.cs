using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class CustomerAddress
    {
        [Key]
        public int AddressId { get; set; }
        public int CustomerId { get; set; }
        [MaxLength(30)]
        public string PhoneNumber { get; set; }
        [MaxLength(30)]
        public string MobileNumber { get; set; }
        [MaxLength(100)]
        public string EmailAddress { get; set; }
        [MaxLength(20)]
        public string Postcode { get; set; }
        [MaxLength(20)]
        public string PropertyNumber { get; set; }
        [MaxLength(50)]
        public string PropertyName { get; set; }
        [MaxLength(50)]
        public string AddressLine1 { get; set; }
        [MaxLength(50)]
        public string AddressLine2 { get; set; }
        [MaxLength(50)]
        public string Town { get; set; }
        [MaxLength(50)]
        public string County { get; set; }

        public CustomerDetails Customer { get; set; }
    }
}
