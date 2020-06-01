using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class RemovedCreationUserIntTheAppUsermodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_LastUpdatedByUserId",
                table: "AspNetUsers");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LastUpdatedByUserId",
                table: "AspNetUsers",
                column: "LastUpdatedByUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_LastUpdatedByUserId",
                table: "AspNetUsers");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LastUpdatedByUserId",
                table: "AspNetUsers",
                column: "LastUpdatedByUserId",
                unique: true,
                filter: "[LastUpdatedByUserId] IS NOT NULL");
        }
    }
}
