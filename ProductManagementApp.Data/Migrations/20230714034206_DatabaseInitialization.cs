using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductManagementApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseInitialization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Product");

            migrationBuilder.EnsureSchema(
                name: "Food");

            migrationBuilder.EnsureSchema(
                name: "AppUser");

            migrationBuilder.CreateTable(
                name: "Category",
                schema: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                schema: "Food",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentSupplier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrimeCost = table.Column<double>(type: "float", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsageUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostPerUnit = table.Column<double>(type: "float", nullable: false),
                    HistoryHighPrice = table.Column<double>(type: "float", nullable: false),
                    HistoryLowPrice = table.Column<double>(type: "float", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngredientTemplate",
                schema: "Food",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Category = table.Column<int>(type: "int", nullable: false),
                    IngredientList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalCost = table.Column<double>(type: "float", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                schema: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartingDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeliveryDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ItemList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderAmount = table.Column<double>(type: "float", nullable: false),
                    AppliedDiscount = table.Column<double>(type: "float", nullable: false),
                    CreditAmount = table.Column<double>(type: "float", nullable: false),
                    Client = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Category = table.Column<int>(type: "int", nullable: false),
                    IngredientList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostPrice = table.Column<double>(type: "float", nullable: false),
                    SalePrice = table.Column<double>(type: "float", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManHour = table.Column<double>(type: "float", nullable: false),
                    IsContinuing = table.Column<bool>(type: "bit", nullable: false),
                    OutOfStock = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "AppUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                schema: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "AppUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "AppUser",
                table: "Role",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "SysAdmin", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 2, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Merchant", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 3, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Supplier", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) },
                    { 4, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Customer", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                schema: "AppUser",
                table: "User",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "Email", "FirstName", "LastName", "MiddleName", "Phone", "Role", "UpdatedBy", "UpdatedDate", "Username" },
                values: new object[,]
                {
                    { new Guid("4b109af5-f84a-45f9-b5da-15b66e59a8df"), "568-6361 Hendrerit Av.", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "sed@google.edu", "Kitra", "Winters", "", "(206) 937-9022", 2, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "KWuser206" },
                    { new Guid("9b32a9ed-dea3-4091-9e47-94bfa929bf49"), "891-3948 Dapibus Rd.", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "mauris@google.org", "Ronan", "Carr", "", "(884) 803-7319", 2, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "RCuser884" },
                    { new Guid("c5e099e8-bebe-4249-a7e4-56b55d553d9d"), "Ap #679-5023 Adipiscing Road", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "sam.zhu992@yahoo.com", "Sam", "Zhu", "", "(992) 471-1352", 1, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "SZuser992" },
                    { new Guid("da4153e9-c1b1-44e3-a180-78e6c4dcf276"), "P.O. Box 869, 6283 Lorem Av.", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "libero.proin@yahoo.net", "Gavin", "Poole", "", "(878) 577-3238", 2, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "GPuser878" },
                    { new Guid("e8718d0d-d31a-48c3-903b-162d1c7a2d12"), "Ap #679-5023 Adipiscing Road", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dictum.cursus@hotmail.com", "Unity", "House", "", "(332) 471-1352", 2, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "UHuser206" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category",
                schema: "Product");

            migrationBuilder.DropTable(
                name: "Ingredient",
                schema: "Food");

            migrationBuilder.DropTable(
                name: "IngredientTemplate",
                schema: "Food");

            migrationBuilder.DropTable(
                name: "Order",
                schema: "Product");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "Product");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "AppUser");

            migrationBuilder.DropTable(
                name: "Supplier",
                schema: "Product");

            migrationBuilder.DropTable(
                name: "User",
                schema: "AppUser");
        }
    }
}
