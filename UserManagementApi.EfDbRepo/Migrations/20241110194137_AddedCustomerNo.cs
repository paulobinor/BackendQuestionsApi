using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserManagementApi.EfDbRepo.Migrations
{
    /// <inheritdoc />
    public partial class AddedCustomerNo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48eef5bc-9e30-4a18-9f1d-cec89310d650");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9eb577c1-dfcf-45cc-9e8f-0eae8c640e9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9ebdcda-94bd-40a7-aa8d-b7858e06f596");

            migrationBuilder.AddColumn<string>(
                name: "CustomerNo",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CustomerNo",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "48eef5bc-9e30-4a18-9f1d-cec89310d650", "2", "User", "User" },
                    { "9eb577c1-dfcf-45cc-9e8f-0eae8c640e9b", "3", "HR", "HR" },
                    { "d9ebdcda-94bd-40a7-aa8d-b7858e06f596", "1", "Admin", "Admin" }
                });
        }
    }
}
