﻿// <auto-generated />
using System;
using FiLogger.Context.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FiLogger.Context.Migrations
{
    [DbContext(typeof(AP_ReplacementContext))]
    [Migration("20190214142307_add-migratin inita")]
    partial class addmigratininita
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FiLogger.Common.Models.CoverDetails", b =>
                {
                    b.Property<int>("CoverDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CoverStartDate");

                    b.Property<bool>("IsProductOnMainOrder");

                    b.Property<int>("PolicyClaimLimitId");

                    b.Property<int>("PolicyDurationId");

                    b.Property<DateTime?>("PresentationDate");

                    b.Property<int>("ProductId");

                    b.Property<decimal>("RetailPrice");

                    b.Property<DateTime?>("TreatmentDate");

                    b.Property<string>("UniqueReference")
                        .HasMaxLength(30);

                    b.HasKey("CoverDetailsId");

                    b.HasIndex("PolicyClaimLimitId");

                    b.HasIndex("PolicyDurationId");

                    b.HasIndex("ProductId");

                    b.ToTable("CoverDetails");
                });

            modelBuilder.Entity("FiLogger.Common.Models.CustomerAddress", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasMaxLength(50);

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(50);

                    b.Property<string>("County")
                        .HasMaxLength(50);

                    b.Property<int>("CustomerId");

                    b.Property<string>("EmailAddress")
                        .HasMaxLength(100);

                    b.Property<string>("MobileNumber")
                        .HasMaxLength(30);

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(30);

                    b.Property<string>("Postcode")
                        .HasMaxLength(20);

                    b.Property<string>("PropertyName")
                        .HasMaxLength(50);

                    b.Property<string>("PropertyNumber")
                        .HasMaxLength(20);

                    b.Property<string>("Town")
                        .HasMaxLength(50);

                    b.HasKey("AddressId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerAddress");
                });

            modelBuilder.Entity("FiLogger.Common.Models.CustomerDetails", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ContactConsent");

                    b.Property<int>("DeferedSalesStatusId");

                    b.Property<int>("DistanceSellingId");

                    b.Property<DateTime?>("FirstContactDate");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<int>("FranchiseId");

                    b.Property<bool>("HasCustomerInitiated");

                    b.Property<bool>("IsOrgansiation");

                    b.Property<string>("OrgansiationName")
                        .HasMaxLength(50);

                    b.Property<int>("PolicyStatusId");

                    b.Property<int>("RetailManagerId");

                    b.Property<int>("SalesPersonId");

                    b.Property<int>("SdnId");

                    b.Property<string>("Surname")
                        .HasMaxLength(50);

                    b.Property<int>("TitleId");

                    b.HasKey("CustomerId");

                    b.HasIndex("DeferedSalesStatusId");

                    b.HasIndex("DistanceSellingId");

                    b.HasIndex("FranchiseId");

                    b.HasIndex("PolicyStatusId");

                    b.HasIndex("RetailManagerId");

                    b.HasIndex("SalesPersonId");

                    b.HasIndex("TitleId");

                    b.ToTable("CustomerDetails");
                });

            modelBuilder.Entity("FiLogger.Common.Models.CustomerDocuments", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<string>("DocumentLocation")
                        .HasMaxLength(50);

                    b.HasKey("DocumentId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerDocuments");
                });

            modelBuilder.Entity("FiLogger.Common.Models.CustomerProducts", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnName("customer_id");

                    b.Property<int>("ProductsId")
                        .HasColumnName("products_id");

                    b.Property<int>("ProductStatusId")
                        .HasColumnName("product_status_id");

                    b.HasKey("CustomerId", "ProductsId");

                    b.HasIndex("ProductStatusId");

                    b.HasIndex("ProductsId");

                    b.ToTable("Customer-Products");
                });

            modelBuilder.Entity("FiLogger.Common.Models.DeferredProductStatus", b =>
                {
                    b.Property<int>("DeferredProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<DateTime?>("PresentationDate");

                    b.Property<bool>("PresentedToCustomer");

                    b.Property<int>("ProductId");

                    b.HasKey("DeferredProductId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("DeferredProductStatus");
                });

            modelBuilder.Entity("FiLogger.Common.Models.DeferredSalesStatus", b =>
                {
                    b.Property<int>("DeferredSalesStatusId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeferredSalesStatusValue")
                        .HasMaxLength(50);

                    b.HasKey("DeferredSalesStatusId");

                    b.ToTable("DeferredSalesStatus");
                });

            modelBuilder.Entity("FiLogger.Common.Models.DistanceSellingAcknowledgementOptions", b =>
                {
                    b.Property<int>("DistanceSellingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DistanceSellingDescription")
                        .HasMaxLength(50);

                    b.HasKey("DistanceSellingId");

                    b.ToTable("DistanceSellingAcknowledgementOptions");
                });

            modelBuilder.Entity("FiLogger.Common.Models.FinanceCompanyOptions", b =>
                {
                    b.Property<int>("FinanceCompanyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FinanceCompanyName")
                        .HasMaxLength(50);

                    b.HasKey("FinanceCompanyId");

                    b.ToTable("FinanceCompanyOptions");
                });

            modelBuilder.Entity("FiLogger.Common.Models.FinanceDetails", b =>
                {
                    b.Property<int>("FinanceDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AmountFinanced");

                    b.Property<int>("AnticipatedMilage");

                    b.Property<int>("ContractedMilage");

                    b.Property<decimal>("FinalPaymentAmount");

                    b.Property<int>("FinanceCompanyId");

                    b.Property<byte>("FinanceTermMonths");

                    b.Property<int>("FinanceTypeId");

                    b.Property<int>("ProductId");

                    b.HasKey("FinanceDetailsId");

                    b.HasIndex("FinanceCompanyId");

                    b.HasIndex("FinanceTypeId");

                    b.HasIndex("ProductId");

                    b.ToTable("FinanceDetails");
                });

            modelBuilder.Entity("FiLogger.Common.Models.FinanceTypeOptions", b =>
                {
                    b.Property<int>("FinanceTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FinanceTypeName")
                        .HasMaxLength(50);

                    b.HasKey("FinanceTypeId");

                    b.ToTable("FinanceTypeOptions");
                });

            modelBuilder.Entity("FiLogger.Common.Models.FranchiseOptions", b =>
                {
                    b.Property<int>("FranchiseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FranshiseName")
                        .HasMaxLength(50);

                    b.HasKey("FranchiseId");

                    b.ToTable("FranchiseOptions");
                });

            modelBuilder.Entity("FiLogger.Common.Models.PolicyClaimLimitOptions", b =>
                {
                    b.Property<int>("PolicyClaimLimitId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PolicyClaimLimitValue")
                        .HasMaxLength(50);

                    b.HasKey("PolicyClaimLimitId");

                    b.ToTable("PolicyClaimLimitOptions");
                });

            modelBuilder.Entity("FiLogger.Common.Models.PolicyDurationOptions", b =>
                {
                    b.Property<int>("PolicyDurationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PolicyDurationValue")
                        .HasMaxLength(50);

                    b.HasKey("PolicyDurationId");

                    b.ToTable("PolicyDurationOptions");
                });

            modelBuilder.Entity("FiLogger.Common.Models.PolicyStatusOptions", b =>
                {
                    b.Property<int>("PolicyStatusId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PolicyStatus")
                        .HasMaxLength(50);

                    b.HasKey("PolicyStatusId");

                    b.ToTable("PolicyStatusOptions");
                });

            modelBuilder.Entity("FiLogger.Common.Models.PolicyType", b =>
                {
                    b.Property<int>("PolicyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PolicyName")
                        .HasMaxLength(50);

                    b.Property<int>("ProductId");

                    b.HasKey("PolicyId");

                    b.HasIndex("ProductId");

                    b.ToTable("PolicyType");
                });

            modelBuilder.Entity("FiLogger.Common.Models.ProductTypeOptions", b =>
                {
                    b.Property<int>("ProductTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductTypeName")
                        .HasMaxLength(50);

                    b.HasKey("ProductTypeId");

                    b.ToTable("ProductTypeOptions");
                });

            modelBuilder.Entity("FiLogger.Common.Models.ProductsAndServicesOptions", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeferredProduct");

                    b.Property<string>("ProductName")
                        .HasMaxLength(50);

                    b.Property<int>("ProductTypeId");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductsAndServicesOptions");
                });

            modelBuilder.Entity("FiLogger.Common.Models.ProductsAndServicesStatusOptions", b =>
                {
                    b.Property<int>("ProductsStatusId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductStatus")
                        .HasMaxLength(50);

                    b.HasKey("ProductsStatusId");

                    b.ToTable("ProductsAndServicesStatusOptions");
                });

            modelBuilder.Entity("FiLogger.Common.Models.RetailManagerOptions", b =>
                {
                    b.Property<int>("RetailManagerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RetailManagerName")
                        .HasMaxLength(50);

                    b.HasKey("RetailManagerId");

                    b.ToTable("RetailManagerOptions");
                });

            modelBuilder.Entity("FiLogger.Common.Models.SalesPersonOptions", b =>
                {
                    b.Property<int>("SalesPersonId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SalesPersonName")
                        .HasMaxLength(50);

                    b.HasKey("SalesPersonId");

                    b.ToTable("SalesPersonOptions");
                });

            modelBuilder.Entity("FiLogger.Common.Models.SdnOptions", b =>
                {
                    b.Property<int>("SdnId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<bool>("IsCommercial");

                    b.Property<bool>("IsFullyComp");

                    b.Property<bool>("IsFullyInsured");

                    b.Property<bool>("IsLeisure");

                    b.Property<bool>("IsPrivateHire");

                    b.HasKey("SdnId");

                    b.HasIndex("CustomerId");

                    b.ToTable("SdnOptions");
                });

            modelBuilder.Entity("FiLogger.Common.Models.TitleOptions", b =>
                {
                    b.Property<int>("TitleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TitleName")
                        .HasMaxLength(30);

                    b.HasKey("TitleId");

                    b.ToTable("TitleOptions");
                });

            modelBuilder.Entity("FiLogger.Common.Models.VehicleDetails", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aspiration")
                        .HasMaxLength(50);

                    b.Property<decimal?>("CurrentMileage");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime?>("DateRegistered");

                    b.Property<DateTime?>("DeliveryDate");

                    b.Property<string>("EngineSize")
                        .HasMaxLength(50);

                    b.Property<decimal?>("InvoiceValue");

                    b.Property<bool>("IsFinanced");

                    b.Property<bool>("IsNew");

                    b.Property<string>("Keyword1")
                        .HasMaxLength(30);

                    b.Property<string>("Keyword2")
                        .HasMaxLength(30);

                    b.Property<string>("Keyword3")
                        .HasMaxLength(30);

                    b.Property<string>("Manufacturer")
                        .HasMaxLength(50);

                    b.Property<string>("Model")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("MotDueDate");

                    b.Property<DateTime?>("PurchasedDate");

                    b.Property<string>("StockId")
                        .HasMaxLength(50);

                    b.Property<bool>("VehicleRegAvailable");

                    b.Property<string>("VehicleRegistration")
                        .HasMaxLength(50);

                    b.Property<int>("VehicleTypeId");

                    b.Property<int>("VehicleUseId");

                    b.Property<DateTime?>("WarrantyExpires");

                    b.HasKey("VehicleId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("VehicleTypeId");

                    b.HasIndex("VehicleUseId");

                    b.ToTable("VehicleDetails");
                });

            modelBuilder.Entity("FiLogger.Common.Models.VehicleTypeOptions", b =>
                {
                    b.Property<int>("VehicleTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VehicleTypeName")
                        .HasMaxLength(50);

                    b.HasKey("VehicleTypeId");

                    b.ToTable("VehicleTypeOptions");
                });

            modelBuilder.Entity("FiLogger.Common.Models.VehicleUseOptions", b =>
                {
                    b.Property<int>("VehicleUseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VehicleUseName")
                        .HasMaxLength(50);

                    b.HasKey("VehicleUseId");

                    b.ToTable("VehicleUseOptions");
                });

            modelBuilder.Entity("FiLogger.Common.Models.CoverDetails", b =>
                {
                    b.HasOne("FiLogger.Common.Models.PolicyClaimLimitOptions", "PolicyClaimLimit")
                        .WithMany("CoverDetails")
                        .HasForeignKey("PolicyClaimLimitId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FiLogger.Common.Models.PolicyDurationOptions", "PolicyDuration")
                        .WithMany("CoverDetails")
                        .HasForeignKey("PolicyDurationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FiLogger.Common.Models.ProductsAndServicesOptions", "Product")
                        .WithMany("CoverDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FiLogger.Common.Models.CustomerAddress", b =>
                {
                    b.HasOne("FiLogger.Common.Models.CustomerDetails", "Customer")
                        .WithMany("CustomerAddress")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FiLogger.Common.Models.CustomerDetails", b =>
                {
                    b.HasOne("FiLogger.Common.Models.DeferredSalesStatus", "DeferedSalesStatus")
                        .WithMany("CustomerDetails")
                        .HasForeignKey("DeferedSalesStatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FiLogger.Common.Models.DistanceSellingAcknowledgementOptions", "DistanceSelling")
                        .WithMany("CustomerDetails")
                        .HasForeignKey("DistanceSellingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FiLogger.Common.Models.FranchiseOptions", "Franchise")
                        .WithMany("CustomerDetails")
                        .HasForeignKey("FranchiseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FiLogger.Common.Models.PolicyStatusOptions", "PolicyStatus")
                        .WithMany("CustomerDetails")
                        .HasForeignKey("PolicyStatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FiLogger.Common.Models.RetailManagerOptions", "RetailManager")
                        .WithMany("CustomerDetails")
                        .HasForeignKey("RetailManagerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FiLogger.Common.Models.SalesPersonOptions", "SalesPerson")
                        .WithMany("CustomerDetails")
                        .HasForeignKey("SalesPersonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FiLogger.Common.Models.TitleOptions", "Title")
                        .WithMany("CustomerDetails")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FiLogger.Common.Models.CustomerDocuments", b =>
                {
                    b.HasOne("FiLogger.Common.Models.CustomerDetails", "Customer")
                        .WithMany("CustomerDocuments")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FiLogger.Common.Models.CustomerProducts", b =>
                {
                    b.HasOne("FiLogger.Common.Models.CustomerDetails", "Customer")
                        .WithMany("CustomerProducts")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Customer-Products_CustomerDetails");

                    b.HasOne("FiLogger.Common.Models.ProductsAndServicesStatusOptions", "ProductStatus")
                        .WithMany("CustomerProducts")
                        .HasForeignKey("ProductStatusId")
                        .HasConstraintName("FK_Customer-Products_ProductsAndServicesStatusOptions");

                    b.HasOne("FiLogger.Common.Models.ProductsAndServicesOptions", "Products")
                        .WithMany("CustomerProducts")
                        .HasForeignKey("ProductsId")
                        .HasConstraintName("FK_Customer-Products_ProductsAndServicesOptions");
                });

            modelBuilder.Entity("FiLogger.Common.Models.DeferredProductStatus", b =>
                {
                    b.HasOne("FiLogger.Common.Models.CustomerDetails", "Customer")
                        .WithMany("DeferredProductStatus")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FiLogger.Common.Models.ProductsAndServicesOptions", "Product")
                        .WithMany("DeferredProductStatus")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FiLogger.Common.Models.FinanceDetails", b =>
                {
                    b.HasOne("FiLogger.Common.Models.FinanceCompanyOptions", "FinanceCompany")
                        .WithMany("FinanceDetails")
                        .HasForeignKey("FinanceCompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FiLogger.Common.Models.FinanceTypeOptions", "FinanceType")
                        .WithMany("FinanceDetails")
                        .HasForeignKey("FinanceTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FiLogger.Common.Models.ProductsAndServicesOptions", "Product")
                        .WithMany("FinanceDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FiLogger.Common.Models.PolicyType", b =>
                {
                    b.HasOne("FiLogger.Common.Models.ProductsAndServicesOptions", "Product")
                        .WithMany("PolicyType")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FiLogger.Common.Models.ProductsAndServicesOptions", b =>
                {
                    b.HasOne("FiLogger.Common.Models.ProductTypeOptions", "ProductType")
                        .WithMany("ProductsAndServicesOptions")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FiLogger.Common.Models.SdnOptions", b =>
                {
                    b.HasOne("FiLogger.Common.Models.CustomerDetails", "Customer")
                        .WithMany("SdnOptions")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FiLogger.Common.Models.VehicleDetails", b =>
                {
                    b.HasOne("FiLogger.Common.Models.CustomerDetails", "Customer")
                        .WithMany("VehicleDetails")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FiLogger.Common.Models.VehicleTypeOptions", "VehicleType")
                        .WithMany("VehicleDetails")
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FiLogger.Common.Models.VehicleUseOptions", "VehicleUse")
                        .WithMany("VehicleDetails")
                        .HasForeignKey("VehicleUseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
