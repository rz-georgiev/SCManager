using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class RemovedUserCompTypesDetails_Table_Due_To_Redundancy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserComponentTypeDetails");

            migrationBuilder.AddColumn<int>(
                name: "UnitMultiplierId",
                table: "UserComponentTypes",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Value",
                table: "UserComponentTypes",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypes_UnitMultiplierId",
                table: "UserComponentTypes",
                column: "UnitMultiplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypes_UnitMultipliers_UnitMultiplierId",
                table: "UserComponentTypes",
                column: "UnitMultiplierId",
                principalTable: "UnitMultipliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypes_UnitMultipliers_UnitMultiplierId",
                table: "UserComponentTypes");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypes_UnitMultiplierId",
                table: "UserComponentTypes");

            migrationBuilder.DropColumn(
                name: "UnitMultiplierId",
                table: "UserComponentTypes");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "UserComponentTypes");

            migrationBuilder.CreateTable(
                name: "UserComponentTypeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdatedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LastUpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UnitMultiplierId = table.Column<int>(type: "int", nullable: true),
                    UserComponentTypeId = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<float>(type: "real", nullable: false)
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
                        name: "FK_UserComponentTypeDetails_UnitMultipliers_UnitMultiplierId",
                        column: x => x.UnitMultiplierId,
                        principalTable: "UnitMultipliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserComponentTypeDetails_UserComponentTypes_UserComponentTypeId",
                        column: x => x.UserComponentTypeId,
                        principalTable: "UserComponentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_UserComponentTypeDetails_UnitMultiplierId",
                table: "UserComponentTypeDetails",
                column: "UnitMultiplierId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypeDetails_UserComponentTypeId",
                table: "UserComponentTypeDetails",
                column: "UserComponentTypeId");
        }
    }
}
