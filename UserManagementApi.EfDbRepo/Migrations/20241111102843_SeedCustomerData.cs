using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserManagementApi.EfDbRepo.Migrations
{
    /// <inheritdoc />
    public partial class SeedCustomerData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11f7ebb6-51ff-4684-80b7-3424174a056b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4aaba62c-f25a-48e7-a887-31aad20a3a96");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9850c49-7d9b-4c29-8424-c710a70006a0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ae3984e7-17e8-4980-99d2-3c0651b32d71", "2", "User", "User" },
                    { "b0504189-f668-4355-9797-85bc87983947", "1", "Admin", "Admin" },
                    { "c8fd82b2-a996-4394-9900-0ee8e412cfb1", "3", "HR", "HR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae3984e7-17e8-4980-99d2-3c0651b32d71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0504189-f668-4355-9797-85bc87983947");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8fd82b2-a996-4394-9900-0ee8e412cfb1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11f7ebb6-51ff-4684-80b7-3424174a056b", "2", "User", "User" },
                    { "4aaba62c-f25a-48e7-a887-31aad20a3a96", "3", "HR", "HR" },
                    { "c9850c49-7d9b-4c29-8424-c710a70006a0", "1", "Admin", "Admin" }
                });
        }
    }
}
