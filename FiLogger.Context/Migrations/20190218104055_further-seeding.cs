using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FiLogger.Context.Migrations
{
    public partial class furtherseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CoverDetails",
                columns: new[] { "CoverDetailsId", "CoverStartDate", "IsProductOnMainOrder", "PolicyClaimLimitId", "PolicyDurationId", "PresentationDate", "ProductId", "RetailPrice", "TreatmentDate", "UniqueReference" },
                values: new object[] { 1, new DateTime(2019, 2, 18, 10, 40, 55, 235, DateTimeKind.Local).AddTicks(4142), false, 1, 1, new DateTime(2019, 2, 18, 10, 40, 55, 235, DateTimeKind.Local).AddTicks(5684), 1, 5000m, new DateTime(2019, 2, 18, 10, 40, 55, 235, DateTimeKind.Local).AddTicks(6884), "ABC 123" });

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

            migrationBuilder.InsertData(
                table: "PolicyType",
                columns: new[] { "PolicyId", "PolicyName", "ProductId" },
                values: new object[,]
                {
                    { 1, "Listers SMART £10 bodyshop  Excess", 1 },
                    { 2, "Listers GAP", 2 },
                    { 3, "Listers Protech Plus Fabric.", 3 },
                    { 4, "Listers Protech Plus Leather.", 3 },
                    { 5, "Listers Protech ", 3 }
                });

            migrationBuilder.UpdateData(
                table: "ProductsAndServicesOptions",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "IsDeferredProduct", "ProductName" },
                values: new object[] { false, "Listers SMART" });

            migrationBuilder.UpdateData(
                table: "ProductsAndServicesOptions",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "IsDeferredProduct", "ProductName", "ProductTypeId" },
                values: new object[] { true, "Listers GAP", 1 });

            migrationBuilder.UpdateData(
                table: "ProductsAndServicesOptions",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ProductName",
                value: "Listers Protech");

            migrationBuilder.InsertData(
                table: "ProductsAndServicesOptions",
                columns: new[] { "ProductId", "IsDeferredProduct", "ProductName", "ProductTypeId" },
                values: new object[,]
                {
                    { 4, false, "Listers Hire Purchase", 2 },
                    { 5, false, "Listers Lease Purchase", 1 }
                });

            migrationBuilder.InsertData(
                table: "SdnOptions",
                columns: new[] { "SdnId", "CustomerId", "IsCommercial", "IsFullyComp", "IsFullyInsured", "IsLeisure", "IsPrivateHire" },
                values: new object[] { 1, 1, false, false, false, false, false });

            migrationBuilder.InsertData(
                table: "VehicleTypeOptions",
                columns: new[] { "VehicleTypeId", "VehicleTypeName" },
                values: new object[,]
                {
                    { 1, "Car" },
                    { 2, "LCV" }
                });

            migrationBuilder.InsertData(
                table: "VehicleUseOptions",
                columns: new[] { "VehicleUseId", "VehicleUseName" },
                values: new object[,]
                {
                    { 1, "Private" },
                    { 2, "Commercial" },
                    { 3, "Hire and Reward" },
                    { 4, "Motability" },
                    { 5, "Business" }
                });

            migrationBuilder.InsertData(
                table: "VehicleDetails",
                columns: new[] { "VehicleId", "Aspiration", "CurrentMileage", "CustomerId", "DateRegistered", "DeliveryDate", "EngineSize", "InvoiceValue", "IsFinanced", "IsNew", "Keyword1", "Keyword2", "Keyword3", "Manufacturer", "Model", "MotDueDate", "PurchasedDate", "StockId", "VehicleRegAvailable", "VehicleRegistration", "VehicleTypeId", "VehicleUseId", "WarrantyExpires" },
                values: new object[] { 1, "Turbo", 50m, 1, new DateTime(2019, 2, 18, 10, 40, 55, 227, DateTimeKind.Local).AddTicks(5856), null, "999cc", null, false, false, "White", "Hatchback", "FWD", "SEAT", "Arona", null, new DateTime(2019, 2, 18, 10, 40, 55, 229, DateTimeKind.Local).AddTicks(3022), null, true, "HGV12FD", 1, 1, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoverDetails",
                keyColumn: "CoverDetailsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PolicyType",
                keyColumn: "PolicyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PolicyType",
                keyColumn: "PolicyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PolicyType",
                keyColumn: "PolicyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PolicyType",
                keyColumn: "PolicyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PolicyType",
                keyColumn: "PolicyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductsAndServicesOptions",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductsAndServicesOptions",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SdnOptions",
                keyColumn: "SdnId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehicleDetails",
                keyColumn: "VehicleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehicleTypeOptions",
                keyColumn: "VehicleTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehicleUseOptions",
                keyColumn: "VehicleUseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehicleUseOptions",
                keyColumn: "VehicleUseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VehicleUseOptions",
                keyColumn: "VehicleUseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VehicleUseOptions",
                keyColumn: "VehicleUseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VehicleTypeOptions",
                keyColumn: "VehicleTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehicleUseOptions",
                keyColumn: "VehicleUseId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "CustomerDetails",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "FirstContactDate",
                value: new DateTime(2019, 2, 18, 9, 52, 50, 332, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "DeferredProductStatus",
                keyColumn: "DeferredProductId",
                keyValue: 1,
                column: "PresentationDate",
                value: new DateTime(2019, 2, 18, 9, 52, 50, 329, DateTimeKind.Local).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "ProductsAndServicesOptions",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "IsDeferredProduct", "ProductName" },
                values: new object[] { true, "Listers GAP" });

            migrationBuilder.UpdateData(
                table: "ProductsAndServicesOptions",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "IsDeferredProduct", "ProductName", "ProductTypeId" },
                values: new object[] { false, "Listers Hire Purchase", 2 });

            migrationBuilder.UpdateData(
                table: "ProductsAndServicesOptions",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ProductName",
                value: "Listers Lease Purchase");
        }
    }
}
