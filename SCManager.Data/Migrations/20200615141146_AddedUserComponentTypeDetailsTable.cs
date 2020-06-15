using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class AddedUserComponentTypeDetailsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComponentTypeDetails_ComponentTypes_ComponentTypeId",
                table: "ComponentTypeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypes_UnitMultipliers_UnitMultiplierId",
                table: "UserComponentTypes");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypes_UnitMultiplierId",
                table: "UserComponentTypes");

            migrationBuilder.DropColumn(
                name: "UnitMultiplierId",
                table: "UserComponentTypes");

            migrationBuilder.AlterColumn<int>(
                name: "ComponentTypeId",
                table: "ComponentTypeDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "UserComponentTypeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    CreatedByUserId = table.Column<string>(nullable: true),
                    LastUpdatedDateTime = table.Column<DateTime>(nullable: true),
                    LastUpdatedByUserId = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    UserComponentTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserComponentTypeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserComponentTypeDetails_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserComponentTypeDetails_AspNetUsers_LastUpdatedByUserId",
                        column: x => x.LastUpdatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserComponentTypeDetails_UserComponentTypes_UserComponentTypeId",
                        column: x => x.UserComponentTypeId,
                        principalTable: "UserComponentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypeDetails_CreatedByUserId",
                table: "UserComponentTypeDetails",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypeDetails_LastUpdatedByUserId",
                table: "UserComponentTypeDetails",
                column: "LastUpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypeDetails_UserComponentTypeId",
                table: "UserComponentTypeDetails",
                column: "UserComponentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentTypeDetails_ComponentTypes_ComponentTypeId",
                table: "ComponentTypeDetails",
                column: "ComponentTypeId",
                principalTable: "ComponentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComponentTypeDetails_ComponentTypes_ComponentTypeId",
                table: "ComponentTypeDetails");

            migrationBuilder.DropTable(
                name: "UserComponentTypeDetails");

            migrationBuilder.AddColumn<int>(
                name: "UnitMultiplierId",
                table: "UserComponentTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ComponentTypeId",
                table: "ComponentTypeDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypes_UnitMultiplierId",
                table: "UserComponentTypes",
                column: "UnitMultiplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentTypeDetails_ComponentTypes_ComponentTypeId",
                table: "ComponentTypeDetails",
                column: "ComponentTypeId",
                principalTable: "ComponentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypes_UnitMultipliers_UnitMultiplierId",
                table: "UserComponentTypes",
                column: "UnitMultiplierId",
                principalTable: "UnitMultipliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
