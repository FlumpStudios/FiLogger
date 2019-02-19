using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FiLogger.Context.Migrations
{
    public partial class evenmoreseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CoverDetails",
                keyColumn: "CoverDetailsId",
                keyValue: 1,
                columns: new[] { "CoverStartDate", "PresentationDate", "TreatmentDate" },
                values: new object[] { new DateTime(2019, 2, 19, 11, 28, 58, 788, DateTimeKind.Local).AddTicks(7131), new DateTime(2019, 2, 19, 11, 28, 58, 788, DateTimeKind.Local).AddTicks(8688), new DateTime(2019, 2, 19, 11, 28, 58, 788, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "FirstContactDate",
                value: new DateTime(2019, 2, 19, 11, 28, 58, 788, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.InsertData(
                table: "CustomerDetails",
                columns: new[] { "CustomerId", "ContactConsent", "DeferedSalesStatusId", "DistanceSellingId", "FirstContactDate", "FirstName", "FranchiseId", "HasCustomerInitiated", "IsOrgansiation", "OrgansiationName", "PolicyStatusId", "RetailManagerId", "SalesPersonId", "SdnId", "Surname", "TitleId" },
                values: new object[,]
                {
                    { 2, true, 1, 2, new DateTime(2019, 2, 19, 11, 28, 58, 788, DateTimeKind.Local).AddTicks(5625), "John", 2, true, true, "New Company LTD", 1, 2, 1, 2, "Smith", 4 },
                    { 3, false, 2, 1, new DateTime(2019, 2, 19, 11, 28, 58, 788, DateTimeKind.Local).AddTicks(6048), "Jane", 2, false, false, null, 1, 1, 2, 3, "Jones", 2 }
                });

            migrationBuilder.UpdateData(
                table: "DeferredProductStatus",
                keyColumn: "DeferredProductId",
                keyValue: 1,
                column: "PresentationDate",
                value: new DateTime(2019, 2, 19, 11, 28, 58, 786, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "VehicleDetails",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "DateRegistered", "PurchasedDate" },
                values: new object[] { new DateTime(2019, 2, 19, 11, 28, 58, 781, DateTimeKind.Local).AddTicks(1514), new DateTime(2019, 2, 19, 11, 28, 58, 782, DateTimeKind.Local).AddTicks(8993) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomerDetails",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CustomerDetails",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "CoverDetails",
                keyColumn: "CoverDetailsId",
                keyValue: 1,
                columns: new[] { "CoverStartDate", "PresentationDate", "TreatmentDate" },
                values: new object[] { new DateTime(2019, 2, 18, 10, 40, 55, 235, DateTimeKind.Local).AddTicks(4142), new DateTime(2019, 2, 18, 10, 40, 55, 235, DateTimeKind.Local).AddTicks(5684), new DateTime(2019, 2, 18, 10, 40, 55, 235, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "FirstContactDate",
                value: new DateTime(2019, 2, 18, 10, 40, 55, 234, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "DeferredProductStatus",
                keyColumn: "DeferredProductId",
                keyValue: 1,
                column: "PresentationDate",
                value: new DateTime(2019, 2, 18, 10, 40, 55, 233, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "VehicleDetails",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "DateRegistered", "PurchasedDate" },
                values: new object[] { new DateTime(2019, 2, 18, 10, 40, 55, 227, DateTimeKind.Local).AddTicks(5856), new DateTime(2019, 2, 18, 10, 40, 55, 229, DateTimeKind.Local).AddTicks(3022) });
        }
    }
}
