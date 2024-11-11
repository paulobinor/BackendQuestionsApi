using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserManagementApi.EfDbRepo.Migrations
{
    /// <inheritdoc />
    public partial class SeedCustomerData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "4d95ce27-e429-4f5d-b136-299e8c3347be", "1", "Admin", "Admin" },
                    { "9367fe5a-733b-4d79-869f-174f639f4044", "2", "User", "User" },
                    { "bc7d1e40-c606-40af-9b43-50efb411d1c9", "3", "HR", "HR" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CustomerNo", "Name" },
                values: new object[,]
                {
                    { -3, "C003", "Akin Mustapha Njoku" },
                    { -2, "C002", "Jane Doe" },
                    { -1, "C001", "John Doe" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d95ce27-e429-4f5d-b136-299e8c3347be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9367fe5a-733b-4d79-869f-174f639f4044");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc7d1e40-c606-40af-9b43-50efb411d1c9");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: -1);

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
    }
}
