using Microsoft.EntityFrameworkCore.Migrations;

namespace HandotaiSeigyo.Data.Migrations
{
    public partial class UnitMultipliersConnectionsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComponentTypeDetails_UnitMultiplier_UnitMultiplierId",
                table: "ComponentTypeDetails");

            migrationBuilder.DropIndex(
                name: "IX_ComponentTypeDetails_UnitMultiplierId",
                table: "ComponentTypeDetails");

            migrationBuilder.DropColumn(
                name: "UnitMultiplierId",
                table: "ComponentTypeDetails");

            migrationBuilder.AddColumn<int>(
                name: "UnitMultiplierId",
                table: "UserComponentTypeDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypeDetails_UnitMultiplierId",
                table: "UserComponentTypeDetails",
                column: "UnitMultiplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypeDetails_UnitMultiplier_UnitMultiplierId",
                table: "UserComponentTypeDetails",
                column: "UnitMultiplierId",
                principalTable: "UnitMultiplier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypeDetails_UnitMultiplier_UnitMultiplierId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypeDetails_UnitMultiplierId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropColumn(
                name: "UnitMultiplierId",
                table: "UserComponentTypeDetails");

            migrationBuilder.AddColumn<int>(
                name: "UnitMultiplierId",
                table: "ComponentTypeDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComponentTypeDetails_UnitMultiplierId",
                table: "ComponentTypeDetails",
                column: "UnitMultiplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentTypeDetails_UnitMultiplier_UnitMultiplierId",
                table: "ComponentTypeDetails",
                column: "UnitMultiplierId",
                principalTable: "UnitMultiplier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
