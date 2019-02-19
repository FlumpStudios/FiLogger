using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FiLogger.Context.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DeferredSalesStatus",
                columns: new[] { "DeferredSalesStatusId", "DeferredSalesStatusValue" },
                values: new object[,]
                {
                    { 1, "Deferred Sale" },
                    { 2, "Customer Can Initiate" },
                    { 3, "Ready For Sale" }
                });

            migrationBuilder.InsertData(
                table: "DistanceSellingAcknowledgementOptions",
                columns: new[] { "DistanceSellingId", "DistanceSellingDescription" },
                values: new object[,]
                {
                    { 1, "if you buy in person..." },
                    { 2, "If you are addressed..." },
                    { 3, "If you purchase..." },
                    { 4, "This is a business..." }
                });

            migrationBuilder.InsertData(
                table: "FinanceCompanyOptions",
                columns: new[] { "FinanceCompanyId", "FinanceCompanyName" },
                values: new object[,]
                {
                    { 4, "Jaguar" },
                    { 3, "Toyota" },
                    { 1, "VMFS" },
                    { 2, "Honda" }
                });

            migrationBuilder.InsertData(
                table: "FinanceTypeOptions",
                columns: new[] { "FinanceTypeId", "FinanceTypeName" },
                values: new object[,]
                {
                    { 1, "PCP" },
                    { 2, "Conditional Sale" },
                    { 4, "Personal Loan" }
                });

            migrationBuilder.InsertData(
                table: "FranchiseOptions",
                columns: new[] { "FranchiseId", "FranshiseName" },
                values: new object[,]
                {
                    { 1, "Non-Franchise sale" },
                    { 2, "Lexus" },
                    { 3, "Honda" }
                });

            migrationBuilder.InsertData(
                table: "PolicyClaimLimitOptions",
                columns: new[] { "PolicyClaimLimitId", "PolicyClaimLimitValue" },
                values: new object[,]
                {
                    { 2, "Purchase Price" },
                    { 1, "Per Cover" }
                });

            migrationBuilder.InsertData(
                table: "PolicyDurationOptions",
                columns: new[] { "PolicyDurationId", "PolicyDurationValue" },
                values: new object[,]
                {
                    { 3, "24 Month" },
                    { 1, "Per cover" },
                    { 2, "12 Month" }
                });

            migrationBuilder.InsertData(
                table: "PolicyStatusOptions",
                columns: new[] { "PolicyStatusId", "PolicyStatus" },
                values: new object[,]
                {
                    { 1, "Partial Quote" },
                    { 2, "Cancelled" },
                    { 3, "Not Taken up" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypeOptions",
                columns: new[] { "ProductTypeId", "ProductTypeName" },
                values: new object[,]
                {
                    { 1, "Cover" },
                    { 2, "Finace" }
                });

            migrationBuilder.InsertData(
                table: "ProductsAndServicesStatusOptions",
                columns: new[] { "ProductsStatusId", "ProductStatus" },
                values: new object[,]
                {
                    { 1, "Not Taken" },
                    { 2, "Taken" },
                    { 3, "Amended" }
                });

            migrationBuilder.InsertData(
                table: "RetailManagerOptions",
                columns: new[] { "RetailManagerId", "RetailManagerName" },
                values: new object[,]
                {
                    { 1, "Richard Branson" },
                    { 2, "Elon Musk" }
                });

            migrationBuilder.InsertData(
                table: "SalesPersonOptions",
                columns: new[] { "SalesPersonId", "SalesPersonName" },
                values: new object[,]
                {
                    { 1, "Richard Branson" },
                    { 2, "Elon Musk" }
                });

            migrationBuilder.InsertData(
                table: "TitleOptions",
                columns: new[] { "TitleId", "TitleName" },
                values: new object[,]
                {
                    { 4, "Mx" },
                    { 3, "Ms" },
                    { 5, "Doctor" },
                    { 1, "Mr" },
                    { 2, "Mrs" },
                    { 6, "Professor" }
                });

            migrationBuilder.InsertData(
                table: "CustomerDetails",
                columns: new[] { "CustomerId", "ContactConsent", "DeferedSalesStatusId", "DistanceSellingId", "FirstContactDate", "FirstName", "FranchiseId", "HasCustomerInitiated", "IsOrgansiation", "OrgansiationName", "PolicyStatusId", "RetailManagerId", "SalesPersonId", "SdnId", "Surname", "TitleId" },
                values: new object[] { 1, false, 1, 1, new DateTime(2019, 2, 18, 9, 52, 50, 332, DateTimeKind.Local).AddTicks(6822), "Tommy", 1, false, false, null, 1, 1, 1, 1, "Test", 1 });

            migrationBuilder.InsertData(
                table: "ProductsAndServicesOptions",
                columns: new[] { "ProductId", "IsDeferredProduct", "ProductName", "ProductTypeId" },
                values: new object[,]
                {
                    { 1, true, "Listers GAP", 1 },
                    { 3, false, "Listers Lease Purchase", 1 },
                    { 2, false, "Listers Hire Purchase", 2 }
                });

            migrationBuilder.InsertData(
                table: "Customer-Products",
                columns: new[] { "customer_id", "products_id", "product_status_id" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "CustomerAddress",
                columns: new[] { "AddressId", "AddressLine1", "AddressLine2", "County", "CustomerId", "EmailAddress", "MobileNumber", "PhoneNumber", "Postcode", "PropertyName", "PropertyNumber", "Town" },
                values: new object[] { 1, "New Street", "Apple Avenue", "Warwickshire", 1, "test@test.com", "01234 678 910", "01895 123456", "CV31 2KJ", null, "5", "New Town" });

            migrationBuilder.InsertData(
                table: "CustomerDocuments",
                columns: new[] { "DocumentId", "CustomerId", "DocumentLocation" },
                values: new object[] { 1, 1, "/documents/1234.pdf" });

            migrationBuilder.InsertData(
                table: "DeferredProductStatus",
                columns: new[] { "DeferredProductId", "CustomerId", "PresentationDate", "PresentedToCustomer", "ProductId" },
                values: new object[] { 1, 1, new DateTime(2019, 2, 18, 9, 52, 50, 329, DateTimeKind.Local).AddTicks(7575), false, 1 });

            migrationBuilder.InsertData(
                table: "FinanceDetails",
                columns: new[] { "FinanceDetailsId", "AmountFinanced", "AnticipatedMilage", "ContractedMilage", "FinalPaymentAmount", "FinanceCompanyId", "FinanceTermMonths", "FinanceTypeId", "ProductId" },
                values: new object[] { 1, 25000m, 1000, 1000, 5000m, 1, (byte)12, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer-Products",
                keyColumns: new[] { "customer_id", "products_id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CustomerAddress",
                keyColumn: "AddressId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CustomerDocuments",
                keyColumn: "DocumentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DeferredProductStatus",
                keyColumn: "DeferredProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DeferredSalesStatus",
                keyColumn: "DeferredSalesStatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DeferredSalesStatus",
                keyColumn: "DeferredSalesStatusId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DistanceSellingAcknowledgementOptions",
                keyColumn: "DistanceSellingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DistanceSellingAcknowledgementOptions",
                keyColumn: "DistanceSellingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DistanceSellingAcknowledgementOptions",
                keyColumn: "DistanceSellingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FinanceCompanyOptions",
                keyColumn: "FinanceCompanyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FinanceCompanyOptions",
                keyColumn: "FinanceCompanyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FinanceCompanyOptions",
                keyColumn: "FinanceCompanyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FinanceDetails",
                keyColumn: "FinanceDetailsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FinanceTypeOptions",
                keyColumn: "FinanceTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FinanceTypeOptions",
                keyColumn: "FinanceTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FranchiseOptions",
                keyColumn: "FranchiseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FranchiseOptions",
                keyColumn: "FranchiseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PolicyClaimLimitOptions",
                keyColumn: "PolicyClaimLimitId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PolicyClaimLimitOptions",
                keyColumn: "PolicyClaimLimitId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PolicyDurationOptions",
                keyColumn: "PolicyDurationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PolicyDurationOptions",
                keyColumn: "PolicyDurationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PolicyDurationOptions",
                keyColumn: "PolicyDurationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PolicyStatusOptions",
                keyColumn: "PolicyStatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PolicyStatusOptions",
                keyColumn: "PolicyStatusId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductsAndServicesOptions",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductsAndServicesOptions",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductsAndServicesStatusOptions",
                keyColumn: "ProductsStatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductsAndServicesStatusOptions",
                keyColumn: "ProductsStatusId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RetailManagerOptions",
                keyColumn: "RetailManagerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SalesPersonOptions",
                keyColumn: "SalesPersonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TitleOptions",
                keyColumn: "TitleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TitleOptions",
                keyColumn: "TitleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TitleOptions",
                keyColumn: "TitleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TitleOptions",
                keyColumn: "TitleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TitleOptions",
                keyColumn: "TitleId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CustomerDetails",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FinanceCompanyOptions",
                keyColumn: "FinanceCompanyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FinanceTypeOptions",
                keyColumn: "FinanceTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTypeOptions",
                keyColumn: "ProductTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductsAndServicesOptions",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductsAndServicesStatusOptions",
                keyColumn: "ProductsStatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DeferredSalesStatus",
                keyColumn: "DeferredSalesStatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DistanceSellingAcknowledgementOptions",
                keyColumn: "DistanceSellingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FranchiseOptions",
                keyColumn: "FranchiseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PolicyStatusOptions",
                keyColumn: "PolicyStatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTypeOptions",
                keyColumn: "ProductTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RetailManagerOptions",
                keyColumn: "RetailManagerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalesPersonOptions",
                keyColumn: "SalesPersonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TitleOptions",
                keyColumn: "TitleId",
                keyValue: 1);
        }
    }
}
