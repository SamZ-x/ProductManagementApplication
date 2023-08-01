using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductManagementApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserEntityAndSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "Product",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "LastName",
                schema: "Product",
                table: "Supplier");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                schema: "Product",
                table: "Supplier",
                newName: "SalesName");

            migrationBuilder.RenameColumn(
                name: "brand",
                schema: "Food",
                table: "Ingredient",
                newName: "Brand");

            migrationBuilder.RenameColumn(
                name: "CostPerUnit",
                schema: "Food",
                table: "Ingredient",
                newName: "Quantity");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                schema: "AppUser",
                table: "User",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                schema: "AppUser",
                table: "User",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                schema: "Product",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<Guid>(
                name: "CurrentSupplier",
                schema: "Food",
                table: "Ingredient",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                schema: "Product",
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Appetizer", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 2, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Dimsum", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 3, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "FireRice", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 4, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "Noodle", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 5, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, "All", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                schema: "Food",
                table: "Ingredient",
                columns: new[] { "Id", "Brand", "Code", "CreatedBy", "CreatedDate", "CurrentSupplier", "Description", "HistoryHighPrice", "HistoryLowPrice", "Name", "PrimeCost", "Quantity", "Unit", "UpdatedBy", "UpdatedDate", "UsageUnit" },
                values: new object[,]
                {
                    { new Guid("04cc37d8-555a-4139-94f4-a2d26cacad4a"), "NoName", "I001", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("1bf9df1a-26a5-4852-9f45-94f1d6c0131e"), null, 14.0, 12.0, "Salt", 14.0, 5.0, "Kg", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "g" },
                    { new Guid("1e674b1e-db3f-4466-93d0-895832c43266"), "NoName", "I006", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("1bf9df1a-26a5-4852-9f45-94f1d6c0131e"), null, 45.0, 40.0, "Soya", 45.0, 20.0, "L", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "g" },
                    { new Guid("63829485-1afd-4e21-910f-553363736493"), "NoName", "I004", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("1bf9df1a-26a5-4852-9f45-94f1d6c0131e"), null, 34.0, 24.0, "Rice Noodle", 34.0, 30.0, "lb", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "g" },
                    { new Guid("764ba3c5-ae6a-4ee2-be7d-bd69fe0f6462"), "NoName", "I003", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("1bf9df1a-26a5-4852-9f45-94f1d6c0131e"), null, 10.0, 9.0, "Wheat Flour", 10.0, 5.0, "Kg", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "g" },
                    { new Guid("b59619f1-bae6-442a-a3f6-ef8487542a7b"), "NoName", "I005", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("1bf9df1a-26a5-4852-9f45-94f1d6c0131e"), null, 34.0, 31.0, "Rice", 34.0, 30.0, "kg", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "g" },
                    { new Guid("f8e9be1a-49f3-401a-9d5e-26926b18b730"), "NoName", "I002", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("1bf9df1a-26a5-4852-9f45-94f1d6c0131e"), null, 15.0, 13.0, "Sugar", 15.0, 5.0, "Kg", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "g" }
                });

            migrationBuilder.InsertData(
                schema: "Food",
                table: "IngredientTemplate",
                columns: new[] { "Id", "Category", "CreatedBy", "CreatedDate", "Description", "IngredientList", "Name", "TotalCost", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("7f9ac754-d077-4818-9df3-2c23ef5a1c0e"), 2, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic ingredient of making buns", "{\"04cc37d8-555a-4139-94f4-a2d26cacad4a\":5.0,\"f8e9be1a-49f3-401a-9d5e-26926b18b730\":30.0,\"764ba3c5-ae6a-4ee2-be7d-bd69fe0f6462\":200.0}", "Bun Base", 0.0, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("dcda4b0c-dc6e-4644-bc95-bb21b3501c04"), 5, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Basic flavor", "{\"04cc37d8-555a-4139-94f4-a2d26cacad4a\":5.0,\"f8e9be1a-49f3-401a-9d5e-26926b18b730\":3.0}", "flavor Base", 0.0, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                schema: "Product",
                table: "Product",
                columns: new[] { "Id", "Category", "CostPrice", "CreatedBy", "CreatedDate", "IngredientList", "IsContinuing", "ManHour", "Name", "OutOfStock", "SalePrice", "Stock", "Unit", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0568983b-5e73-49cf-9829-544e49febb2e"), 1, 1.8999999999999999, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, true, 1.0, "Mix Vegetable Soup", false, 3.5, 999, "each", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("1a96b935-0bdd-4a9f-98e9-d4be5dc1146e"), 1, 4.2999999999999998, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, true, 1.0, "Sweet Wings", false, 8.0, 999, "pack", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("34e9683e-7421-4421-bcfe-15015391cc1e"), 2, 1.2, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, true, 1.0, "SpicyPork Bun", false, 6.0, 999, "pack", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("88e708ac-47a9-4dab-aaf4-d75b2e1a039e"), 4, 5.5, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, true, 1.0, "ShangHai Fire Noodle", false, 9.0, 999, "each", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("9d37e8bd-c979-4b47-9c87-0a530e0c19a0"), 3, 3.5, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, true, 1.0, "Beef Rice", false, 8.0, 999, "each", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                schema: "Product",
                table: "Supplier",
                columns: new[] { "Id", "Address", "CompanyName", "CreatedBy", "CreatedDate", "Email", "Phone", "SalesName", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("1bf9df1a-26a5-4852-9f45-94f1d6c0131e"), "4588 104St SE, Edmonton, AB", "WangDa Wholesale", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "wdwhole@yahoo.com", "(780)445-1458", "Alex", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "AppUser",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4b109af5-f84a-45f9-b5da-15b66e59a8df"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 146, 181, 198, 78, 154, 237, 193, 123, 199, 128, 211, 107, 85, 7, 226, 9, 168, 98, 31, 200, 196, 1, 133, 94, 231, 59, 224, 179, 101, 179, 28, 209, 27, 91, 140, 130, 225, 55, 210, 111, 13, 140, 76, 84, 126, 198, 121, 222, 21, 242, 33, 238, 233, 119, 129, 211, 30, 163, 15, 87, 6, 118, 142, 142 }, new byte[] { 98, 159, 179, 33, 211, 211, 158, 96, 32, 15, 17, 210, 73, 163, 12, 153, 210, 156, 2, 91, 159, 17, 214, 248, 83, 153, 181, 184, 133, 188, 240, 207, 117, 153, 166, 6, 126, 204, 214, 68, 7, 144, 232, 128, 27, 122, 103, 213, 63, 95, 3, 100, 180, 33, 38, 86, 1, 12, 156, 140, 38, 153, 75, 196 } });

            migrationBuilder.UpdateData(
                schema: "AppUser",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9b32a9ed-dea3-4091-9e47-94bfa929bf49"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 146, 181, 198, 78, 154, 237, 193, 123, 199, 128, 211, 107, 85, 7, 226, 9, 168, 98, 31, 200, 196, 1, 133, 94, 231, 59, 224, 179, 101, 179, 28, 209, 27, 91, 140, 130, 225, 55, 210, 111, 13, 140, 76, 84, 126, 198, 121, 222, 21, 242, 33, 238, 233, 119, 129, 211, 30, 163, 15, 87, 6, 118, 142, 142 }, new byte[] { 98, 159, 179, 33, 211, 211, 158, 96, 32, 15, 17, 210, 73, 163, 12, 153, 210, 156, 2, 91, 159, 17, 214, 248, 83, 153, 181, 184, 133, 188, 240, 207, 117, 153, 166, 6, 126, 204, 214, 68, 7, 144, 232, 128, 27, 122, 103, 213, 63, 95, 3, 100, 180, 33, 38, 86, 1, 12, 156, 140, 38, 153, 75, 196 } });

            migrationBuilder.UpdateData(
                schema: "AppUser",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c5e099e8-bebe-4249-a7e4-56b55d553d9d"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 146, 181, 198, 78, 154, 237, 193, 123, 199, 128, 211, 107, 85, 7, 226, 9, 168, 98, 31, 200, 196, 1, 133, 94, 231, 59, 224, 179, 101, 179, 28, 209, 27, 91, 140, 130, 225, 55, 210, 111, 13, 140, 76, 84, 126, 198, 121, 222, 21, 242, 33, 238, 233, 119, 129, 211, 30, 163, 15, 87, 6, 118, 142, 142 }, new byte[] { 98, 159, 179, 33, 211, 211, 158, 96, 32, 15, 17, 210, 73, 163, 12, 153, 210, 156, 2, 91, 159, 17, 214, 248, 83, 153, 181, 184, 133, 188, 240, 207, 117, 153, 166, 6, 126, 204, 214, 68, 7, 144, 232, 128, 27, 122, 103, 213, 63, 95, 3, 100, 180, 33, 38, 86, 1, 12, 156, 140, 38, 153, 75, 196 } });

            migrationBuilder.UpdateData(
                schema: "AppUser",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("da4153e9-c1b1-44e3-a180-78e6c4dcf276"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 146, 181, 198, 78, 154, 237, 193, 123, 199, 128, 211, 107, 85, 7, 226, 9, 168, 98, 31, 200, 196, 1, 133, 94, 231, 59, 224, 179, 101, 179, 28, 209, 27, 91, 140, 130, 225, 55, 210, 111, 13, 140, 76, 84, 126, 198, 121, 222, 21, 242, 33, 238, 233, 119, 129, 211, 30, 163, 15, 87, 6, 118, 142, 142 }, new byte[] { 98, 159, 179, 33, 211, 211, 158, 96, 32, 15, 17, 210, 73, 163, 12, 153, 210, 156, 2, 91, 159, 17, 214, 248, 83, 153, 181, 184, 133, 188, 240, 207, 117, 153, 166, 6, 126, 204, 214, 68, 7, 144, 232, 128, 27, 122, 103, 213, 63, 95, 3, 100, 180, 33, 38, 86, 1, 12, 156, 140, 38, 153, 75, 196 } });

            migrationBuilder.UpdateData(
                schema: "AppUser",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e8718d0d-d31a-48c3-903b-162d1c7a2d12"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 146, 181, 198, 78, 154, 237, 193, 123, 199, 128, 211, 107, 85, 7, 226, 9, 168, 98, 31, 200, 196, 1, 133, 94, 231, 59, 224, 179, 101, 179, 28, 209, 27, 91, 140, 130, 225, 55, 210, 111, 13, 140, 76, 84, 126, 198, 121, 222, 21, 242, 33, 238, 233, 119, 129, 211, 30, 163, 15, 87, 6, 118, 142, 142 }, new byte[] { 98, 159, 179, 33, 211, 211, 158, 96, 32, 15, 17, 210, 73, 163, 12, 153, 210, 156, 2, 91, 159, 17, 214, 248, 83, 153, 181, 184, 133, 188, 240, 207, 117, 153, 166, 6, 126, 204, 214, 68, 7, 144, 232, 128, 27, 122, 103, 213, 63, 95, 3, 100, 180, 33, 38, 86, 1, 12, 156, 140, 38, 153, 75, 196 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Product",
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Food",
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("04cc37d8-555a-4139-94f4-a2d26cacad4a"));

            migrationBuilder.DeleteData(
                schema: "Food",
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("1e674b1e-db3f-4466-93d0-895832c43266"));

            migrationBuilder.DeleteData(
                schema: "Food",
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("63829485-1afd-4e21-910f-553363736493"));

            migrationBuilder.DeleteData(
                schema: "Food",
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("764ba3c5-ae6a-4ee2-be7d-bd69fe0f6462"));

            migrationBuilder.DeleteData(
                schema: "Food",
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("b59619f1-bae6-442a-a3f6-ef8487542a7b"));

            migrationBuilder.DeleteData(
                schema: "Food",
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("f8e9be1a-49f3-401a-9d5e-26926b18b730"));

            migrationBuilder.DeleteData(
                schema: "Food",
                table: "IngredientTemplate",
                keyColumn: "Id",
                keyValue: new Guid("7f9ac754-d077-4818-9df3-2c23ef5a1c0e"));

            migrationBuilder.DeleteData(
                schema: "Food",
                table: "IngredientTemplate",
                keyColumn: "Id",
                keyValue: new Guid("dcda4b0c-dc6e-4644-bc95-bb21b3501c04"));

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0568983b-5e73-49cf-9829-544e49febb2e"));

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1a96b935-0bdd-4a9f-98e9-d4be5dc1146e"));

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("34e9683e-7421-4421-bcfe-15015391cc1e"));

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("88e708ac-47a9-4dab-aaf4-d75b2e1a039e"));

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9d37e8bd-c979-4b47-9c87-0a530e0c19a0"));

            migrationBuilder.DeleteData(
                schema: "Product",
                table: "Supplier",
                keyColumn: "Id",
                keyValue: new Guid("1bf9df1a-26a5-4852-9f45-94f1d6c0131e"));

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                schema: "AppUser",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                schema: "AppUser",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Stock",
                schema: "Product",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "SalesName",
                schema: "Product",
                table: "Supplier",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "Brand",
                schema: "Food",
                table: "Ingredient",
                newName: "brand");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                schema: "Food",
                table: "Ingredient",
                newName: "CostPerUnit");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "Product",
                table: "Supplier",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                schema: "Product",
                table: "Supplier",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CurrentSupplier",
                schema: "Food",
                table: "Ingredient",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);
        }
    }
}
