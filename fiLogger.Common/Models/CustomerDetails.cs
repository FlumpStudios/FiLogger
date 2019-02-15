using CryptoLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FiLogger.Common.Models
{
    public class CustomerDetails
    {
        public CustomerDetails()
        {
            CustomerAddress = new HashSet<CustomerAddress>();
            CustomerDocuments = new HashSet<CustomerDocuments>();
            CustomerProducts = new HashSet<CustomerProducts>();
            DeferredProductStatus = new HashSet<DeferredProductStatus>();
            SdnOptions = new HashSet<SdnOptions>();
            VehicleDetails = new HashSet<VehicleDetails>();
        }

        [Key]
        public int CustomerId { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }
        public int TitleId { get; set; }
        public DateTime? FirstContactDate { get; set; }
        public bool HasCustomerInitiated { get; set; }
        public int DeferedSalesStatusId { get; set; }
        public bool ContactConsent { get; set; }
        public int DistanceSellingId { get; set; }
        public int PolicyStatusId { get; set; }
        public int FranchiseId { get; set; }
        public int SalesPersonId { get; set; }
        public int RetailManagerId { get; set; }
        public int SdnId { get; set; }
        public bool IsOrgansiation { get; set; }
        [MaxLength(50)]
        public string OrgansiationName { get; set; }

        public DeferredSalesStatus DeferedSalesStatus { get; set; }
        public DistanceSellingAcknowledgementOptions DistanceSelling { get; set; }
        public FranchiseOptions Franchise { get; set; }
        public PolicyStatusOptions PolicyStatus { get; set; }
        public RetailManagerOptions RetailManager { get; set; }
        public SalesPersonOptions SalesPerson { get; set; }
        public TitleOptions Title { get; set; }
        public ICollection<CustomerAddress> CustomerAddress { get; set; }
        public ICollection<CustomerDocuments> CustomerDocuments { get; set; }
        public ICollection<CustomerProducts> CustomerProducts { get; set; }
        public ICollection<DeferredProductStatus> DeferredProductStatus { get; set; }
        public ICollection<SdnOptions> SdnOptions { get; set; }
        public ICollection<VehicleDetails> VehicleDetails { get; set; }
    }
}
