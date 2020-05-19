using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class AttempToMakeTwoIdentityConnections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_IdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypes_IdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.AddColumn<string>(
                name: "LastIdentityUserId",
                table: "UserComponentTypes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NewIdentityUserId",
                table: "UserComponentTypes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypes_LastIdentityUserId",
                table: "UserComponentTypes",
                column: "LastIdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypes_NewIdentityUserId",
                table: "UserComponentTypes",
                column: "NewIdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_LastIdentityUserId",
                table: "UserComponentTypes",
                column: "LastIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_NewIdentityUserId",
                table: "UserComponentTypes",
                column: "NewIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_LastIdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_NewIdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypes_LastIdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypes_NewIdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropColumn(
                name: "LastIdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropColumn(
                name: "NewIdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "UserComponentTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypes_IdentityUserId",
                table: "UserComponentTypes",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_IdentityUserId",
                table: "UserComponentTypes",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
