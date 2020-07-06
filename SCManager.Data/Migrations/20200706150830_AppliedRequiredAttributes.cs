using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class AppliedRequiredAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComponentTypeDetails_AspNetUsers_CreatedByUserId",
                table: "ComponentTypeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ComponentTypes_AspNetUsers_CreatedByUserId",
                table: "ComponentTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_StaticSiteInfos_AspNetUsers_CreatedByUserId",
                table: "StaticSiteInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_UnitMultipliers_AspNetUsers_CreatedByUserId",
                table: "UnitMultipliers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypeDetails_AspNetUsers_CreatedByUserId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_CreatedByUserId",
                table: "UserComponentTypes");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                table: "UserComponentTypes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                table: "UserComponentTypeDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UnitMultipliers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                table: "UnitMultipliers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StaticSiteInfos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                table: "StaticSiteInfos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "StaticSiteInfos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ComponentTypes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                table: "ComponentTypes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Unit",
                table: "ComponentTypeDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Symbol",
                table: "ComponentTypeDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ComponentTypeDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                table: "ComponentTypeDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentTypeDetails_AspNetUsers_CreatedByUserId",
                table: "ComponentTypeDetails",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentTypes_AspNetUsers_CreatedByUserId",
                table: "ComponentTypes",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_StaticSiteInfos_AspNetUsers_CreatedByUserId",
                table: "StaticSiteInfos",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnitMultipliers_AspNetUsers_CreatedByUserId",
                table: "UnitMultipliers",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypeDetails_AspNetUsers_CreatedByUserId",
                table: "UserComponentTypeDetails",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_CreatedByUserId",
                table: "UserComponentTypes",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComponentTypeDetails_AspNetUsers_CreatedByUserId",
                table: "ComponentTypeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ComponentTypes_AspNetUsers_CreatedByUserId",
                table: "ComponentTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_StaticSiteInfos_AspNetUsers_CreatedByUserId",
                table: "StaticSiteInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_UnitMultipliers_AspNetUsers_CreatedByUserId",
                table: "UnitMultipliers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypeDetails_AspNetUsers_CreatedByUserId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_CreatedByUserId",
                table: "UserComponentTypes");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                table: "UserComponentTypes",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                table: "UserComponentTypeDetails",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UnitMultipliers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                table: "UnitMultipliers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StaticSiteInfos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                table: "StaticSiteInfos",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "StaticSiteInfos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ComponentTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                table: "ComponentTypes",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Unit",
                table: "ComponentTypeDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Symbol",
                table: "ComponentTypeDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ComponentTypeDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                table: "ComponentTypeDetails",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentTypeDetails_AspNetUsers_CreatedByUserId",
                table: "ComponentTypeDetails",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentTypes_AspNetUsers_CreatedByUserId",
                table: "ComponentTypes",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_StaticSiteInfos_AspNetUsers_CreatedByUserId",
                table: "StaticSiteInfos",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnitMultipliers_AspNetUsers_CreatedByUserId",
                table: "UnitMultipliers",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypeDetails_AspNetUsers_CreatedByUserId",
                table: "UserComponentTypeDetails",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_CreatedByUserId",
                table: "UserComponentTypes",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
