using Microsoft.EntityFrameworkCore.Migrations;

namespace HandotaiSeigyo.Data.Migrations
{
    public partial class RemovedLazyLoadingProxies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypeDetails_ComponentTypeDetails_ComponentTypeDetailId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_IdentityUserId1",
                table: "UserComponentTypes");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypes_IdentityUserId1",
                table: "UserComponentTypes");

            migrationBuilder.DropColumn(
                name: "IdentityUserId1",
                table: "UserComponentTypes");

            migrationBuilder.DropColumn(
                name: "UserTypeComponentId",
                table: "UserComponentTypeDetails");

            migrationBuilder.AlterColumn<string>(
                name: "IdentityUserId",
                table: "UserComponentTypes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ComponentTypeDetailId",
                table: "UserComponentTypeDetails",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypes_IdentityUserId",
                table: "UserComponentTypes",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypeDetails_ComponentTypeDetails_ComponentTypeDetailId",
                table: "UserComponentTypeDetails",
                column: "ComponentTypeDetailId",
                principalTable: "ComponentTypeDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_IdentityUserId",
                table: "UserComponentTypes",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypeDetails_ComponentTypeDetails_ComponentTypeDetailId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_IdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypes_IdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.AlterColumn<int>(
                name: "IdentityUserId",
                table: "UserComponentTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId1",
                table: "UserComponentTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ComponentTypeDetailId",
                table: "UserComponentTypeDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserTypeComponentId",
                table: "UserComponentTypeDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypes_IdentityUserId1",
                table: "UserComponentTypes",
                column: "IdentityUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypeDetails_ComponentTypeDetails_ComponentTypeDetailId",
                table: "UserComponentTypeDetails",
                column: "ComponentTypeDetailId",
                principalTable: "ComponentTypeDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_IdentityUserId1",
                table: "UserComponentTypes",
                column: "IdentityUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
