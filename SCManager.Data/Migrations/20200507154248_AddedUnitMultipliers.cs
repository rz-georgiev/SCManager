using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class AddedUnitMultipliers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnitMultiplierId",
                table: "ComponentTypeDetails",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UnitMultiplier",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    LastUpdatedDateTime = table.Column<DateTime>(nullable: true),
                    CreatedByIdentityUserId = table.Column<string>(nullable: true),
                    LastUpdatedByIdentityUserId = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitMultiplier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitMultiplier_AspNetUsers_CreatedByIdentityUserId",
                        column: x => x.CreatedByIdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnitMultiplier_AspNetUsers_LastUpdatedByIdentityUserId",
                        column: x => x.LastUpdatedByIdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComponentTypeDetails_UnitMultiplierId",
                table: "ComponentTypeDetails",
                column: "UnitMultiplierId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitMultiplier_CreatedByIdentityUserId",
                table: "UnitMultiplier",
                column: "CreatedByIdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitMultiplier_LastUpdatedByIdentityUserId",
                table: "UnitMultiplier",
                column: "LastUpdatedByIdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentTypeDetails_UnitMultiplier_UnitMultiplierId",
                table: "ComponentTypeDetails",
                column: "UnitMultiplierId",
                principalTable: "UnitMultiplier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComponentTypeDetails_UnitMultiplier_UnitMultiplierId",
                table: "ComponentTypeDetails");

            migrationBuilder.DropTable(
                name: "UnitMultiplier");

            migrationBuilder.DropIndex(
                name: "IX_ComponentTypeDetails_UnitMultiplierId",
                table: "ComponentTypeDetails");

            migrationBuilder.DropColumn(
                name: "UnitMultiplierId",
                table: "ComponentTypeDetails");
        }
    }
}
