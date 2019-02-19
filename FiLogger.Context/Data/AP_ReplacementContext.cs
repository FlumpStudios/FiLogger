using FiLogger.Common.Models;
using FiLogger.Common.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions;
using Microsoft.Extensions.Options;
using System;

namespace FiLogger.Context.Data
{
    public class AP_ReplacementContext : DbContext
    {      
        private readonly IOptions<AppSettings> _appSettings;


        public AP_ReplacementContext(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        public AP_ReplacementContext(DbContextOptions<AP_ReplacementContext> options, IOptions<AppSettings> appSettings)
            : base(options)
        {
            _appSettings = appSettings;
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


        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Use the fluent API to create a composite key on customerProducts Junction table - PM 14.02.19
            modelBuilder.Entity<CustomerProducts>(entity => {
                entity.HasKey(e => new {
                    e.CustomerId,
                    e.ProductsId
                });

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

            //Seed the database
            if (_appSettings.Value.Database.SeedDbOnCreate) DBInitialiser.SeedDB(modelBuilder);
        }

    }
}


