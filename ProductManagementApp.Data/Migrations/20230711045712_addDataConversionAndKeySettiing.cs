using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductManagementApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class addDataConversionAndKeySettiing : Migration
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
