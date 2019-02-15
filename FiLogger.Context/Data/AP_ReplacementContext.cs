using FiLogger.Common.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace FiLogger.Context.Data
{
    public class AP_ReplacementContext : DbContext
    {
        public AP_ReplacementContext()
        {
        }

        public AP_ReplacementContext(DbContextOptions<AP_ReplacementContext> options)
            : base(options)
        {
        }

        public DbSet<CoverDetails> CoverDetails { get; set; }
        public DbSet<CustomerAddress> CustomerAddress { get; set; }
        public DbSet<CustomerDetails> CustomerDetails { get; set; }
        public DbSet<CustomerDocuments> CustomerDocuments { get; set; }
        public DbSet<CustomerProducts> CustomerProducts { get; set; }
        public DbSet<DeferredProductStatus> DeferredProductStatus { get; set; }
        public DbSet<DeferredSalesStatus> DeferredSalesStatus { get; set; }
        public DbSet<DistanceSellingAcknowledgementOptions> DistanceSellingAcknowledgementOptions { get; set; }
        public DbSet<FinanceCompanyOptions> FinanceCompanyOptions { get; set; }
        public DbSet<FinanceDetails> FinanceDetails { get; set; }
        public DbSet<FinanceTypeOptions> FinanceTypeOptions { get; set; }
        public DbSet<FranchiseOptions> FranchiseOptions { get; set; }
        public DbSet<PolicyClaimLimitOptions> PolicyClaimLimitOptions { get; set; }
        public DbSet<PolicyDurationOptions> PolicyDurationOptions { get; set; }
        public DbSet<PolicyStatusOptions> PolicyStatusOptions { get; set; }
        public DbSet<PolicyType> PolicyType { get; set; }
        public DbSet<ProductsAndServicesOptions> ProductsAndServicesOptions { get; set; }
        public DbSet<ProductsAndServicesStatusOptions> ProductsAndServicesStatusOptions { get; set; }
        public DbSet<ProductTypeOptions> ProductTypeOptions { get; set; }
        public DbSet<RetailManagerOptions> RetailManagerOptions { get; set; }
        public DbSet<SalesPersonOptions> SalesPersonOptions { get; set; }
        public DbSet<SdnOptions> SdnOptions { get; set; }
        public DbSet<TitleOptions> TitleOptions { get; set; }
        public DbSet<VehicleDetails> VehicleDetails { get; set; }
        public DbSet<VehicleTypeOptions> VehicleTypeOptions { get; set; }
        public DbSet<VehicleUseOptions> VehicleUseOptions { get; set; }




        //Use the fluent API to create a composite key on customerProducts Junction table - PM 14.02.19

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerProducts>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.ProductsId });

                entity.ToTable("Customer-Products");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.ProductsId).HasColumnName("products_id");

                entity.Property(e => e.ProductStatusId).HasColumnName("product_status_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerProducts)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer-Products_CustomerDetails");

                entity.HasOne(d => d.ProductStatus)
                    .WithMany(p => p.CustomerProducts)
                    .HasForeignKey(d => d.ProductStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer-Products_ProductsAndServicesStatusOptions");

                entity.HasOne(d => d.Products)
                    .WithMany(p => p.CustomerProducts)
                    .HasForeignKey(d => d.ProductsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer-Products_ProductsAndServicesOptions");
            });


            //Below is an example of how to autopoulate a db when it's created. Not sure if we'll be wanting this for dev later... PM 14/02/2019
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
                IsOrgansiation = false
            });

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
                DocumentId=1,
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

   

            modelBuilder.Entity<ProductsAndServicesOptions>().HasData(new ProductsAndServicesOptions
            {
                ProductId = 1,
                ProductName = "Listers GAP",
                IsDeferredProduct = true

            },
             new ProductsAndServicesOptions
             {
                 ProductId = 2,
                 ProductName = "Listers Hire Purchase",
                 IsDeferredProduct = false

             },
             new ProductsAndServicesOptions
             {
                 ProductId = 3,
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




        }
    }
}


