using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductManagementApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class DbContextConfiguration : Migration
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

            migrationBuilder.RenameTable(
                name: "User",
                newName: "User",
                newSchema: "AppUser");

            migrationBuilder.RenameTable(
                name: "Supplier",
                newName: "Supplier",
                newSchema: "Product");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Product",
                newSchema: "Product");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Order",
                newSchema: "Product");

            migrationBuilder.RenameTable(
                name: "IngredientTemplate",
                newName: "IngredientTemplate",
                newSchema: "Food");

            migrationBuilder.RenameTable(
                name: "Ingredient",
                newName: "Ingredient",
                newSchema: "Food");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Category",
                newSchema: "Product");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                schema: "AppUser",
                table: "User",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdateBy",
                schema: "AppUser",
                table: "User",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                schema: "AppUser",
                table: "User",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                schema: "AppUser",
                table: "User",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                schema: "Product",
                table: "Supplier",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdateBy",
                schema: "Product",
                table: "Supplier",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                schema: "Product",
                table: "Supplier",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                schema: "Product",
                table: "Supplier",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                schema: "Product",
                table: "Product",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdateBy",
                schema: "Product",
                table: "Product",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                schema: "Product",
                table: "Product",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                schema: "Product",
                table: "Product",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                schema: "Product",
                table: "Order",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdateBy",
                schema: "Product",
                table: "Order",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                schema: "Product",
                table: "Order",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                schema: "Product",
                table: "Order",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                schema: "Food",
                table: "IngredientTemplate",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdateBy",
                schema: "Food",
                table: "IngredientTemplate",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                schema: "Food",
                table: "IngredientTemplate",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                schema: "Food",
                table: "IngredientTemplate",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                schema: "Food",
                table: "Ingredient",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdateBy",
                schema: "Food",
                table: "Ingredient",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                schema: "Food",
                table: "Ingredient",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                schema: "Food",
                table: "Ingredient",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                schema: "Product",
                table: "Category",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdateBy",
                schema: "Product",
                table: "Category",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                schema: "Product",
                table: "Category",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                schema: "Product",
                table: "Category",
                newName: "CreatedBy");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                schema: "AppUser",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "AppUser",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "AppUser",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IngredientList",
                schema: "Product",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemList",
                schema: "Product",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Food",
                table: "IngredientTemplate",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IngredientList",
                schema: "Food",
                table: "IngredientTemplate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Food",
                table: "Ingredient",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                schema: "Food",
                table: "Ingredient",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "AppUser",
                table: "User",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "FirstName", "LastName", "MiddleName", "Phone", "Role", "UpdatedBy", "UpdatedDate", "Username" },
                values: new object[] { new Guid("1b1c209b-1af9-49f3-9d8b-c57d65752215"), "3948 123Ave, Edmonton, AB", new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Gavin", "Poole", null, "(878)577-3238", 2, new Guid("4af36f59-a750-4d33-ab0a-c29e59defe11"), new DateTimeOffset(new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "GavinP" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "AppUser",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1b1c209b-1af9-49f3-9d8b-c57d65752215"));

            migrationBuilder.DropColumn(
                name: "IngredientList",
                schema: "Product",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ItemList",
                schema: "Product",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "IngredientList",
                schema: "Food",
                table: "IngredientTemplate");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "AppUser",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Supplier",
                schema: "Product",
                newName: "Supplier");

            migrationBuilder.RenameTable(
                name: "Product",
                schema: "Product",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Order",
                schema: "Product",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "IngredientTemplate",
                schema: "Food",
                newName: "IngredientTemplate");

            migrationBuilder.RenameTable(
                name: "Ingredient",
                schema: "Food",
                newName: "Ingredient");

            migrationBuilder.RenameTable(
                name: "Category",
                schema: "Product",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "User",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "User",
                newName: "UpdateBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "User",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "User",
                newName: "CreateBy");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Supplier",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Supplier",
                newName: "UpdateBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Supplier",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Supplier",
                newName: "CreateBy");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Product",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Product",
                newName: "UpdateBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Product",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Product",
                newName: "CreateBy");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Order",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Order",
                newName: "UpdateBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Order",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Order",
                newName: "CreateBy");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "IngredientTemplate",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "IngredientTemplate",
                newName: "UpdateBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "IngredientTemplate",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "IngredientTemplate",
                newName: "CreateBy");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Ingredient",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Ingredient",
                newName: "UpdateBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Ingredient",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Ingredient",
                newName: "CreateBy");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Category",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Category",
                newName: "UpdateBy");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Category",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Category",
                newName: "CreateBy");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "IngredientTemplate",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Ingredient",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Ingredient",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
