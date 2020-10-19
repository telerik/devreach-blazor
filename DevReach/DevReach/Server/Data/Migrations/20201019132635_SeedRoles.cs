using Microsoft.EntityFrameworkCore.Migrations;

namespace DevReach.Server.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9a629737-2d5e-4e56-a3a5-f10b8c3cc546", "5e0284ed-3033-40eb-a9e3-46aab2f17a82", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a629737-2d5e-4e56-a3a5-f10b8c3cc546");
        }
    }
}
