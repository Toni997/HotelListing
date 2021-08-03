using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class AddedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d085ebdc-aee2-481e-b4bd-80f3669b9a9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0bab5fc-9df6-421e-996e-951a09a77257");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d3631f9a-aa2a-473e-9dea-2c6438452678", "685b6150-73cf-478e-8e7b-9d4edd06c723", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a63c5c2-d16e-45aa-ad3d-b0e977692fb6", "1dc9f62d-d259-4829-8a20-c9bc4ca418a6", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a63c5c2-d16e-45aa-ad3d-b0e977692fb6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3631f9a-aa2a-473e-9dea-2c6438452678");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0bab5fc-9df6-421e-996e-951a09a77257", "7156fae2-5000-4ebc-b482-6900d350c57f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d085ebdc-aee2-481e-b4bd-80f3669b9a9a", "3d2b2151-374e-47e7-a785-44bae2bb102c", "Administrator", "ADMINISTRATOR" });
        }
    }
}
