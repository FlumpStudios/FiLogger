using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FiLogger.Context.Migrations
{
    public partial class addmigratininita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeferredSalesStatus",
                columns: table => new
                {
                    DeferredSalesStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeferredSalesStatusValue = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeferredSalesStatus", x => x.DeferredSalesStatusId);
                });

            migrationBuilder.CreateTable(
                name: "DistanceSellingAcknowledgementOptions",
                columns: table => new
                {
                    DistanceSellingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DistanceSellingDescription = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistanceSellingAcknowledgementOptions", x => x.DistanceSellingId);
                });

            migrationBuilder.CreateTable(
                name: "FinanceCompanyOptions",
                columns: table => new
                {
                    FinanceCompanyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FinanceCompanyName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceCompanyOptions", x => x.FinanceCompanyId);
                });

            migrationBuilder.CreateTable(
                name: "FinanceTypeOptions",
                columns: table => new
                {
                    FinanceTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FinanceTypeName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceTypeOptions", x => x.FinanceTypeId);
                });

            migrationBuilder.CreateTable(
                name: "FranchiseOptions",
                columns: table => new
                {
                    FranchiseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FranshiseName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FranchiseOptions", x => x.FranchiseId);
                });

            migrationBuilder.CreateTable(
                name: "PolicyClaimLimitOptions",
                columns: table => new
                {
                    PolicyClaimLimitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PolicyClaimLimitValue = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyClaimLimitOptions", x => x.PolicyClaimLimitId);
                });

            migrationBuilder.CreateTable(
                name: "PolicyDurationOptions",
                columns: table => new
                {
                    PolicyDurationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PolicyDurationValue = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyDurationOptions", x => x.PolicyDurationId);
                });

            migrationBuilder.CreateTable(
                name: "PolicyStatusOptions",
                columns: table => new
                {
                    PolicyStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PolicyStatus = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyStatusOptions", x => x.PolicyStatusId);
                });

            migrationBuilder.CreateTable(
                name: "ProductsAndServicesStatusOptions",
                columns: table => new
                {
                    ProductsStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductStatus = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsAndServicesStatusOptions", x => x.ProductsStatusId);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypeOptions",
                columns: table => new
                {
                    ProductTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductTypeName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypeOptions", x => x.ProductTypeId);
                });

            migrationBuilder.CreateTable(
                name: "RetailManagerOptions",
                columns: table => new
                {
                    RetailManagerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RetailManagerName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetailManagerOptions", x => x.RetailManagerId);
                });

            migrationBuilder.CreateTable(
                name: "SalesPersonOptions",
                columns: table => new
                {
                    SalesPersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SalesPersonName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesPersonOptions", x => x.SalesPersonId);
                });

            migrationBuilder.CreateTable(
                name: "TitleOptions",
                columns: table => new
                {
                    TitleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TitleName = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleOptions", x => x.TitleId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTypeOptions",
                columns: table => new
                {
                    VehicleTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VehicleTypeName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTypeOptions", x => x.VehicleTypeId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleUseOptions",
                columns: table => new
                {
                    VehicleUseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VehicleUseName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleUseOptions", x => x.VehicleUseId);
                });

            migrationBuilder.CreateTable(
                name: "ProductsAndServicesOptions",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductName = table.Column<string>(maxLength: 50, nullable: true),
                    ProductTypeId = table.Column<int>(nullable: false),
                    IsDeferredProduct = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsAndServicesOptions", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_ProductsAndServicesOptions_ProductTypeOptions_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypeOptions",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerDetails",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    Surname = table.Column<string>(maxLength: 50, nullable: true),
                    TitleId = table.Column<int>(nullable: false),
                    FirstContactDate = table.Column<DateTime>(nullable: true),
                    HasCustomerInitiated = table.Column<bool>(nullable: false),
                    DeferedSalesStatusId = table.Column<int>(nullable: false),
                    ContactConsent = table.Column<bool>(nullable: false),
                    DistanceSellingId = table.Column<int>(nullable: false),
                    PolicyStatusId = table.Column<int>(nullable: false),
                    FranchiseId = table.Column<int>(nullable: false),
                    SalesPersonId = table.Column<int>(nullable: false),
                    RetailManagerId = table.Column<int>(nullable: false),
                    SdnId = table.Column<int>(nullable: false),
                    IsOrgansiation = table.Column<bool>(nullable: false),
                    OrgansiationName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDetails", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_CustomerDetails_DeferredSalesStatus_DeferedSalesStatusId",
                        column: x => x.DeferedSalesStatusId,
                        principalTable: "DeferredSalesStatus",
                        principalColumn: "DeferredSalesStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerDetails_DistanceSellingAcknowledgementOptions_DistanceSellingId",
                        column: x => x.DistanceSellingId,
                        principalTable: "DistanceSellingAcknowledgementOptions",
                        principalColumn: "DistanceSellingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerDetails_FranchiseOptions_FranchiseId",
                        column: x => x.FranchiseId,
                        principalTable: "FranchiseOptions",
                        principalColumn: "FranchiseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerDetails_PolicyStatusOptions_PolicyStatusId",
                        column: x => x.PolicyStatusId,
                        principalTable: "PolicyStatusOptions",
                        principalColumn: "PolicyStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerDetails_RetailManagerOptions_RetailManagerId",
                        column: x => x.RetailManagerId,
                        principalTable: "RetailManagerOptions",
                        principalColumn: "RetailManagerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerDetails_SalesPersonOptions_SalesPersonId",
                        column: x => x.SalesPersonId,
                        principalTable: "SalesPersonOptions",
                        principalColumn: "SalesPersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerDetails_TitleOptions_TitleId",
                        column: x => x.TitleId,
                        principalTable: "TitleOptions",
                        principalColumn: "TitleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoverDetails",
                columns: table => new
                {
                    CoverDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RetailPrice = table.Column<decimal>(nullable: false),
                    PresentationDate = table.Column<DateTime>(nullable: true),
                    CoverStartDate = table.Column<DateTime>(nullable: true),
                    IsProductOnMainOrder = table.Column<bool>(nullable: false),
                    TreatmentDate = table.Column<DateTime>(nullable: true),
                    UniqueReference = table.Column<string>(maxLength: 30, nullable: true),
                    PolicyDurationId = table.Column<int>(nullable: false),
                    PolicyClaimLimitId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoverDetails", x => x.CoverDetailsId);
                    table.ForeignKey(
                        name: "FK_CoverDetails_PolicyClaimLimitOptions_PolicyClaimLimitId",
                        column: x => x.PolicyClaimLimitId,
                        principalTable: "PolicyClaimLimitOptions",
                        principalColumn: "PolicyClaimLimitId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoverDetails_PolicyDurationOptions_PolicyDurationId",
                        column: x => x.PolicyDurationId,
                        principalTable: "PolicyDurationOptions",
                        principalColumn: "PolicyDurationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoverDetails_ProductsAndServicesOptions_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductsAndServicesOptions",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinanceDetails",
                columns: table => new
                {
                    FinanceDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FinanceTypeId = table.Column<int>(nullable: false),
                    FinanceCompanyId = table.Column<int>(nullable: false),
                    FinalPaymentAmount = table.Column<decimal>(nullable: false),
                    AmountFinanced = table.Column<decimal>(nullable: false),
                    FinanceTermMonths = table.Column<byte>(nullable: false),
                    ContractedMilage = table.Column<int>(nullable: false),
                    AnticipatedMilage = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceDetails", x => x.FinanceDetailsId);
                    table.ForeignKey(
                        name: "FK_FinanceDetails_FinanceCompanyOptions_FinanceCompanyId",
                        column: x => x.FinanceCompanyId,
                        principalTable: "FinanceCompanyOptions",
                        principalColumn: "FinanceCompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FinanceDetails_FinanceTypeOptions_FinanceTypeId",
                        column: x => x.FinanceTypeId,
                        principalTable: "FinanceTypeOptions",
                        principalColumn: "FinanceTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FinanceDetails_ProductsAndServicesOptions_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductsAndServicesOptions",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PolicyType",
                columns: table => new
                {
                    PolicyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PolicyName = table.Column<string>(maxLength: 50, nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyType", x => x.PolicyId);
                    table.ForeignKey(
                        name: "FK_PolicyType_ProductsAndServicesOptions_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductsAndServicesOptions",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddress",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 30, nullable: true),
                    MobileNumber = table.Column<string>(maxLength: 30, nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 100, nullable: true),
                    Postcode = table.Column<string>(maxLength: 20, nullable: true),
                    PropertyNumber = table.Column<string>(maxLength: 20, nullable: true),
                    PropertyName = table.Column<string>(maxLength: 50, nullable: true),
                    AddressLine1 = table.Column<string>(maxLength: 50, nullable: true),
                    AddressLine2 = table.Column<string>(maxLength: 50, nullable: true),
                    Town = table.Column<string>(maxLength: 50, nullable: true),
                    County = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddress", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_CustomerDetails_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerDetails",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerDocuments",
                columns: table => new
                {
                    DocumentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DocumentLocation = table.Column<string>(maxLength: 50, nullable: true),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDocuments", x => x.DocumentId);
                    table.ForeignKey(
                        name: "FK_CustomerDocuments_CustomerDetails_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerDetails",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customer-Products",
                columns: table => new
                {
                    customer_id = table.Column<int>(nullable: false),
                    products_id = table.Column<int>(nullable: false),
                    product_status_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer-Products", x => new { x.customer_id, x.products_id });
                    table.ForeignKey(
                        name: "FK_Customer-Products_CustomerDetails",
                        column: x => x.customer_id,
                        principalTable: "CustomerDetails",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer-Products_ProductsAndServicesStatusOptions",
                        column: x => x.product_status_id,
                        principalTable: "ProductsAndServicesStatusOptions",
                        principalColumn: "ProductsStatusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer-Products_ProductsAndServicesOptions",
                        column: x => x.products_id,
                        principalTable: "ProductsAndServicesOptions",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeferredProductStatus",
                columns: table => new
                {
                    DeferredProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    PresentationDate = table.Column<DateTime>(nullable: true),
                    PresentedToCustomer = table.Column<bool>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeferredProductStatus", x => x.DeferredProductId);
                    table.ForeignKey(
                        name: "FK_DeferredProductStatus_CustomerDetails_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerDetails",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeferredProductStatus_ProductsAndServicesOptions_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductsAndServicesOptions",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SdnOptions",
                columns: table => new
                {
                    SdnId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    IsCommercial = table.Column<bool>(nullable: false),
                    IsPrivateHire = table.Column<bool>(nullable: false),
                    IsFullyComp = table.Column<bool>(nullable: false),
                    IsFullyInsured = table.Column<bool>(nullable: false),
                    IsLeisure = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SdnOptions", x => x.SdnId);
                    table.ForeignKey(
                        name: "FK_SdnOptions_CustomerDetails_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerDetails",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleDetails",
                columns: table => new
                {
                    VehicleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    VehicleTypeId = table.Column<int>(nullable: false),
                    VehicleRegAvailable = table.Column<bool>(nullable: false),
                    VehicleRegistration = table.Column<string>(maxLength: 50, nullable: true),
                    Manufacturer = table.Column<string>(maxLength: 50, nullable: true),
                    Model = table.Column<string>(maxLength: 50, nullable: true),
                    Aspiration = table.Column<string>(maxLength: 50, nullable: true),
                    EngineSize = table.Column<string>(maxLength: 50, nullable: true),
                    Keyword1 = table.Column<string>(maxLength: 30, nullable: true),
                    Keyword2 = table.Column<string>(maxLength: 30, nullable: true),
                    Keyword3 = table.Column<string>(maxLength: 30, nullable: true),
                    DateRegistered = table.Column<DateTime>(nullable: true),
                    PurchasedDate = table.Column<DateTime>(nullable: true),
                    CurrentMileage = table.Column<decimal>(nullable: true),
                    InvoiceValue = table.Column<decimal>(nullable: true),
                    IsNew = table.Column<bool>(nullable: false),
                    IsFinanced = table.Column<bool>(nullable: false),
                    VehicleUseId = table.Column<int>(nullable: false),
                    StockId = table.Column<string>(maxLength: 50, nullable: true),
                    WarrantyExpires = table.Column<DateTime>(nullable: true),
                    DeliveryDate = table.Column<DateTime>(nullable: true),
                    MotDueDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleDetails", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_VehicleDetails_CustomerDetails_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerDetails",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleDetails_VehicleTypeOptions_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypeOptions",
                        principalColumn: "VehicleTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleDetails_VehicleUseOptions_VehicleUseId",
                        column: x => x.VehicleUseId,
                        principalTable: "VehicleUseOptions",
                        principalColumn: "VehicleUseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoverDetails_PolicyClaimLimitId",
                table: "CoverDetails",
                column: "PolicyClaimLimitId");

            migrationBuilder.CreateIndex(
                name: "IX_CoverDetails_PolicyDurationId",
                table: "CoverDetails",
                column: "PolicyDurationId");

            migrationBuilder.CreateIndex(
                name: "IX_CoverDetails_ProductId",
                table: "CoverDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_CustomerId",
                table: "CustomerAddress",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_DeferedSalesStatusId",
                table: "CustomerDetails",
                column: "DeferedSalesStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_DistanceSellingId",
                table: "CustomerDetails",
                column: "DistanceSellingId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_FranchiseId",
                table: "CustomerDetails",
                column: "FranchiseId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_PolicyStatusId",
                table: "CustomerDetails",
                column: "PolicyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_RetailManagerId",
                table: "CustomerDetails",
                column: "RetailManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_SalesPersonId",
                table: "CustomerDetails",
                column: "SalesPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_TitleId",
                table: "CustomerDetails",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDocuments_CustomerId",
                table: "CustomerDocuments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer-Products_product_status_id",
                table: "Customer-Products",
                column: "product_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_Customer-Products_products_id",
                table: "Customer-Products",
                column: "products_id");

            migrationBuilder.CreateIndex(
                name: "IX_DeferredProductStatus_CustomerId",
                table: "DeferredProductStatus",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_DeferredProductStatus_ProductId",
                table: "DeferredProductStatus",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_FinanceDetails_FinanceCompanyId",
                table: "FinanceDetails",
                column: "FinanceCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_FinanceDetails_FinanceTypeId",
                table: "FinanceDetails",
                column: "FinanceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FinanceDetails_ProductId",
                table: "FinanceDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyType_ProductId",
                table: "PolicyType",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsAndServicesOptions_ProductTypeId",
                table: "ProductsAndServicesOptions",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SdnOptions_CustomerId",
                table: "SdnOptions",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDetails_CustomerId",
                table: "VehicleDetails",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDetails_VehicleTypeId",
                table: "VehicleDetails",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDetails_VehicleUseId",
                table: "VehicleDetails",
                column: "VehicleUseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoverDetails");

            migrationBuilder.DropTable(
                name: "CustomerAddress");

            migrationBuilder.DropTable(
                name: "CustomerDocuments");

            migrationBuilder.DropTable(
                name: "Customer-Products");

            migrationBuilder.DropTable(
                name: "DeferredProductStatus");

            migrationBuilder.DropTable(
                name: "FinanceDetails");

            migrationBuilder.DropTable(
                name: "PolicyType");

            migrationBuilder.DropTable(
                name: "SdnOptions");

            migrationBuilder.DropTable(
                name: "VehicleDetails");

            migrationBuilder.DropTable(
                name: "PolicyClaimLimitOptions");

            migrationBuilder.DropTable(
                name: "PolicyDurationOptions");

            migrationBuilder.DropTable(
                name: "ProductsAndServicesStatusOptions");

            migrationBuilder.DropTable(
                name: "FinanceCompanyOptions");

            migrationBuilder.DropTable(
                name: "FinanceTypeOptions");

            migrationBuilder.DropTable(
                name: "ProductsAndServicesOptions");

            migrationBuilder.DropTable(
                name: "CustomerDetails");

            migrationBuilder.DropTable(
                name: "VehicleTypeOptions");

            migrationBuilder.DropTable(
                name: "VehicleUseOptions");

            migrationBuilder.DropTable(
                name: "ProductTypeOptions");

            migrationBuilder.DropTable(
                name: "DeferredSalesStatus");

            migrationBuilder.DropTable(
                name: "DistanceSellingAcknowledgementOptions");

            migrationBuilder.DropTable(
                name: "FranchiseOptions");

            migrationBuilder.DropTable(
                name: "PolicyStatusOptions");

            migrationBuilder.DropTable(
                name: "RetailManagerOptions");

            migrationBuilder.DropTable(
                name: "SalesPersonOptions");

            migrationBuilder.DropTable(
                name: "TitleOptions");
        }
    }
}
