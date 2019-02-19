using FiLogger.Common.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiLogger.Context.Data
{
    public static class DBInitialiser
    {

        /// <summary>
        /// Static method for generating seeding the database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void SeedDB(ModelBuilder modelBuilder)
        {   
            modelBuilder.Entity<TitleOptions>().HasData(new TitleOptions
            {
                TitleId = 1,
                TitleName = "Mr"
            },
             new TitleOptions
             {
                 TitleId = 2,
                 TitleName = "Mrs"
             },
             new TitleOptions
             {
                 TitleId = 3,
                 TitleName = "Ms"
             },
             new TitleOptions
             {
                 TitleId = 4,
                 TitleName = "Mx"
             },
             new TitleOptions
             {
                 TitleId = 5,
                 TitleName = "Doctor"
             },
             new TitleOptions
             {
                 TitleId = 6,
                 TitleName = "Professor"
             });

            modelBuilder.Entity<FinanceTypeOptions>().HasData(new FinanceTypeOptions
            {
                FinanceTypeId = 1,
                FinanceTypeName = "PCP"
            },
             new FinanceTypeOptions
             {
                 FinanceTypeId = 2,
                 FinanceTypeName = "Conditional Sale"
             },
             new FinanceTypeOptions
             {
                 FinanceTypeId = 4,
                 FinanceTypeName = "Personal Loan"
             }
            );

            modelBuilder.Entity<DeferredSalesStatus>().HasData(new DeferredSalesStatus
            {
                DeferredSalesStatusId = 1,
                DeferredSalesStatusValue = "Deferred Sale"
            },
             new DeferredSalesStatus
             {
                 DeferredSalesStatusId = 2,
                 DeferredSalesStatusValue = "Customer Can Initiate"
             },
             new DeferredSalesStatus
             {
                 DeferredSalesStatusId = 3,
                 DeferredSalesStatusValue = "Ready For Sale"
             });

            modelBuilder.Entity<DistanceSellingAcknowledgementOptions>().HasData(new DistanceSellingAcknowledgementOptions
            {
                DistanceSellingId = 1,
                DistanceSellingDescription = "if you buy in person..."
            },
             new DistanceSellingAcknowledgementOptions
             {
                 DistanceSellingId = 2,
                 DistanceSellingDescription = "If you are addressed..."
             },
             new DistanceSellingAcknowledgementOptions
             {
                 DistanceSellingId = 3,
                 DistanceSellingDescription = "If you purchase..."
             },
             new DistanceSellingAcknowledgementOptions
             {
                 DistanceSellingId = 4,
                 DistanceSellingDescription = "This is a business..."
             });

            modelBuilder.Entity<FinanceCompanyOptions>().HasData(new FinanceCompanyOptions
            {
                FinanceCompanyId = 1,
                FinanceCompanyName = "VMFS"
            },
             new FinanceCompanyOptions
             {
                 FinanceCompanyId = 2,
                 FinanceCompanyName = "Honda"
             },
             new FinanceCompanyOptions
             {
                 FinanceCompanyId = 3,
                 FinanceCompanyName = "Toyota"
             },
             new FinanceCompanyOptions
             {
                 FinanceCompanyId = 4,
                 FinanceCompanyName = "Jaguar"
             });

            modelBuilder.Entity<VehicleUseOptions>().HasData(
             new VehicleUseOptions
             {
                 VehicleUseId = 1,
                 VehicleUseName = "Private"
             },
             new VehicleUseOptions
             {
                 VehicleUseId = 2,
                 VehicleUseName = "Commercial"
             },
             new VehicleUseOptions
             {
                 VehicleUseId = 3,
                 VehicleUseName = "Hire and Reward"
             },
             new VehicleUseOptions
             {
                 VehicleUseId = 4,
                 VehicleUseName = "Motability"
             },
             new VehicleUseOptions
             {
                 VehicleUseId = 5,
                 VehicleUseName = "Business"
             }
            );

            modelBuilder.Entity<VehicleTypeOptions>().HasData(
             new VehicleTypeOptions
             {
                 VehicleTypeId = 1,
                 VehicleTypeName = "Car"
             },
             new VehicleTypeOptions
             {
                 VehicleTypeId = 2,
                 VehicleTypeName = "LCV"
             }
            );

            modelBuilder.Entity<VehicleDetails>().HasData(
             new VehicleDetails
             {
                 VehicleId = 1,
                 CustomerId = 1,
                 VehicleTypeId = 1,
                 VehicleRegistration = "HGV12FD",
                 Manufacturer = "SEAT",
                 Model = "Arona",
                 Aspiration = "Turbo",
                 EngineSize = "999cc",
                 Keyword1 = "White",
                 Keyword2 = "Hatchback",
                 Keyword3 = "FWD",
                 DateRegistered = DateTime.Now,
                 PurchasedDate = DateTime.Now,
                 CurrentMileage = 50,
                 VehicleRegAvailable = true,
                 VehicleUseId = 1
             }
            );

            modelBuilder.Entity<FranchiseOptions>().HasData(new FranchiseOptions
            {
                FranchiseId = 1,
                FranshiseName = "Non-Franchise sale"

            },
             new FranchiseOptions
             {
                 FranchiseId = 2,
                 FranshiseName = "Lexus"
             },
             new FranchiseOptions
             {
                 FranchiseId = 3,
                 FranshiseName = "Honda"
             }
            );

            modelBuilder.Entity<PolicyClaimLimitOptions>().HasData(new PolicyClaimLimitOptions
            {
                PolicyClaimLimitId = 1,
                PolicyClaimLimitValue = "Per Cover"

            },
             new PolicyClaimLimitOptions
             {
                 PolicyClaimLimitId = 2,
                 PolicyClaimLimitValue = "Purchase Price"
             }
            );

            modelBuilder.Entity<SdnOptions>().HasData(new SdnOptions
            {
                SdnId = 1,
                CustomerId = 1,
                IsCommercial = false,
                IsFullyComp = false,
                IsFullyInsured = false,
                IsLeisure = false,
                IsPrivateHire = false
            });

            modelBuilder.Entity<PolicyDurationOptions>().HasData(new PolicyDurationOptions
            {
                PolicyDurationId = 1,
                PolicyDurationValue = "Per cover"

            },
             new PolicyDurationOptions
             {
                 PolicyDurationId = 2,
                 PolicyDurationValue = "12 Month"
             },
             new PolicyDurationOptions
             {
                 PolicyDurationId = 3,
                 PolicyDurationValue = "24 Month"
             }
            );

            modelBuilder.Entity<PolicyStatusOptions>().HasData(new PolicyStatusOptions
            {
                PolicyStatusId = 1,
                PolicyStatus = "Partial Quote"

            },
             new PolicyStatusOptions
             {
                 PolicyStatusId = 2,
                 PolicyStatus = "Cancelled"
             },
             new PolicyStatusOptions
             {
                 PolicyStatusId = 3,
                 PolicyStatus = "Not Taken up"
             });

            modelBuilder.Entity<ProductTypeOptions>().HasData(new ProductTypeOptions
            {
                ProductTypeId = 1,
                ProductTypeName = "Cover"
            },
             new ProductTypeOptions
             {
                 ProductTypeId = 2,
                 ProductTypeName = "Finace"
             }
            );

            modelBuilder.Entity<ProductsAndServicesOptions>().HasData(
             new ProductsAndServicesOptions
             {
                 ProductId = 1,
                 ProductTypeId = 1,
                 ProductName = "Listers SMART",
                 IsDeferredProduct = false
             },
             new ProductsAndServicesOptions
             {
                 ProductId = 2,
                 ProductTypeId = 1,
                 ProductName = "Listers GAP",
                 IsDeferredProduct = true
             },
             new ProductsAndServicesOptions
             {
                 ProductId = 3,
                 ProductTypeId = 1,
                 ProductName = "Listers Protech",
                 IsDeferredProduct = false
             },
             new ProductsAndServicesOptions
             {
                 ProductId = 4,
                 ProductTypeId = 2,
                 ProductName = "Listers Hire Purchase",
                 IsDeferredProduct = false

             },
             new ProductsAndServicesOptions
             {
                 ProductId = 5,
                 ProductTypeId = 1,
                 ProductName = "Listers Lease Purchase",
                 IsDeferredProduct = false
             }
            );

            modelBuilder.Entity<ProductsAndServicesStatusOptions>().HasData(new ProductsAndServicesStatusOptions
            {
                ProductsStatusId = 1,
                ProductStatus = "Not Taken"
            },
             new ProductsAndServicesStatusOptions
             {
                 ProductsStatusId = 2,
                 ProductStatus = "Taken"

             },
             new ProductsAndServicesStatusOptions
             {
                 ProductsStatusId = 3,
                 ProductStatus = "Amended"
             }
            );

            modelBuilder.Entity<RetailManagerOptions>().HasData(new RetailManagerOptions
            {
                RetailManagerId = 1,
                RetailManagerName = "Richard Branson"
            },
             new RetailManagerOptions
             {
                 RetailManagerId = 2,
                 RetailManagerName = "Elon Musk"
             }
            );

            modelBuilder.Entity<SalesPersonOptions>().HasData(new SalesPersonOptions
            {
                SalesPersonId = 1,
                SalesPersonName = "Richard Branson"
            },
             new SalesPersonOptions
             {
                 SalesPersonId = 2,
                 SalesPersonName = "Elon Musk"
             }
            );

            modelBuilder.Entity<CustomerAddress>().HasData(new CustomerAddress
            {
                AddressId = 1,
                AddressLine1 = "New Street",
                AddressLine2 = "Apple Avenue",
                County = "Warwickshire",
                CustomerId = 1,
                EmailAddress = "test@test.com",
                MobileNumber = "01234 678 910",
                PhoneNumber = "01895 123456",
                Postcode = "CV31 2KJ",
                PropertyNumber = "5",
                Town = "New Town"
            });

            modelBuilder.Entity<CustomerDocuments>().HasData(new CustomerDocuments
            {
                CustomerId = 1,
                DocumentId = 1,
                DocumentLocation = "/documents/1234.pdf"
            });

            modelBuilder.Entity<CustomerProducts>().HasData(new CustomerProducts
            {
                CustomerId = 1,
                ProductsId = 1,
                ProductStatusId = 1
            });

            modelBuilder.Entity<DeferredProductStatus>().HasData(new DeferredProductStatus
            {
                CustomerId = 1,
                DeferredProductId = 1,
                PresentationDate = DateTime.Now,
                PresentedToCustomer = false,
                ProductId = 1
            });

            modelBuilder.Entity<FinanceDetails>().HasData(new FinanceDetails
            {
                FinanceDetailsId = 1,
                FinanceCompanyId = 1,
                FinanceTypeId = 1,
                FinalPaymentAmount = 5000,
                AmountFinanced = 25000,
                AnticipatedMilage = 1000,
                ContractedMilage = 1000,
                FinanceTermMonths = 12,
                ProductId = 1
            });

            modelBuilder.Entity<CustomerDetails>().HasData(new CustomerDetails
            {
                CustomerId = 1,
                FirstName = "Tommy",
                Surname = "Test",
                ContactConsent = false,
                FirstContactDate = DateTime.Now,
                TitleId = 1,
                HasCustomerInitiated = false,
                DistanceSellingId = 1,
                PolicyStatusId = 1,
                FranchiseId = 1,
                SalesPersonId = 1,
                RetailManagerId = 1,
                SdnId = 1,
                IsOrgansiation = false,
                DeferedSalesStatusId = 1
            },
            new CustomerDetails
            {
                CustomerId = 2,
                FirstName = "John",
                Surname = "Smith",
                ContactConsent = true,
                FirstContactDate = DateTime.Now,
                TitleId = 4,
                HasCustomerInitiated = true,
                DistanceSellingId = 2,
                PolicyStatusId = 1,
                FranchiseId = 2,
                SalesPersonId = 1,
                RetailManagerId = 2,
                SdnId = 2,
                IsOrgansiation = true,
                DeferedSalesStatusId = 1,
                OrgansiationName="New Company LTD"
            },
            new CustomerDetails
            {
                CustomerId = 3,
                FirstName = "Jane",
                Surname = "Jones",
                ContactConsent = false,
                FirstContactDate = DateTime.Now,
                TitleId = 2,
                HasCustomerInitiated = false,
                DistanceSellingId = 1,
                PolicyStatusId = 1,
                FranchiseId = 2,
                SalesPersonId = 2,
                RetailManagerId = 1,
                SdnId = 3,
                IsOrgansiation = false,
                DeferedSalesStatusId = 2
            }
            );

            modelBuilder.Entity<CoverDetails>().HasData(new CoverDetails()
            {
                CoverDetailsId = 1,
                CoverStartDate = DateTime.Now,
                IsProductOnMainOrder = false,
                PolicyClaimLimitId = 1,
                PolicyDurationId = 1,
                PresentationDate = DateTime.Now,
                ProductId = 1,
                RetailPrice = 5000,
                TreatmentDate = DateTime.Now,
                UniqueReference = "ABC 123"
            });

            modelBuilder.Entity<PolicyType>().HasData(new PolicyType()
            {
                PolicyId = 1,
                PolicyName = "Listers SMART £10 bodyshop  Excess",
                ProductId = 1
            },
             new PolicyType
             {
                 PolicyId = 2,
                 PolicyName = "Listers GAP",
                 ProductId = 2
             },
             new PolicyType
             {
                 PolicyId = 3,
                 PolicyName = "Listers Protech Plus Fabric.",
                 ProductId = 3
             },
             new PolicyType
             {
                 PolicyId = 4,
                 PolicyName = "Listers Protech Plus Leather.",
                 ProductId = 3
             },
             new PolicyType
             {
                 PolicyId = 5,
                 PolicyName = "Listers Protech ",
                 ProductId = 3
             }
            );
        }
    }
}