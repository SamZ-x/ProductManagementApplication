using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductManagementApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                schema: "AppUser",
                table: "User",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "AppUser",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4b109af5-f84a-45f9-b5da-15b66e59a8df"),
                column: "Password",
                value: "abcde12345");

            migrationBuilder.UpdateData(
                schema: "AppUser",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9b32a9ed-dea3-4091-9e47-94bfa929bf49"),
                column: "Password",
                value: "abcde12345");

            migrationBuilder.UpdateData(
                schema: "AppUser",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c5e099e8-bebe-4249-a7e4-56b55d553d9d"),
                column: "Password",
                value: "abcde12345");

            migrationBuilder.UpdateData(
                schema: "AppUser",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("da4153e9-c1b1-44e3-a180-78e6c4dcf276"),
                column: "Password",
                value: "abcde12345");

            migrationBuilder.UpdateData(
                schema: "AppUser",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e8718d0d-d31a-48c3-903b-162d1c7a2d12"),
                column: "Password",
                value: "abcde12345");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                schema: "AppUser",
                table: "User");
        }
    }
}
