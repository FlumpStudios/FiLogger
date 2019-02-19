using System;
using System.ComponentModel.DataAnnotations;

namespace FiLogger.API.DataContracts.Customer
{
    public class CustomerDetails
    {   
            public int CustomerId { get; set; }
            [Required]
            public string FirstName { get; set; }           
            [Required]
            public string Surname { get; set; }
            [Required]
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
            public string OrgansiationName { get; set; }
    }
}
