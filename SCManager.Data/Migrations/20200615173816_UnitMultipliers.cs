using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class UnitMultipliers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnitMultiplierId",
                table: "UserComponentTypeDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypeDetails_UnitMultiplierId",
                table: "UserComponentTypeDetails",
                column: "UnitMultiplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypeDetails_UnitMultipliers_UnitMultiplierId",
                table: "UserComponentTypeDetails",
                column: "UnitMultiplierId",
                principalTable: "UnitMultipliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypeDetails_UnitMultipliers_UnitMultiplierId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypeDetails_UnitMultiplierId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropColumn(
                name: "UnitMultiplierId",
                table: "UserComponentTypeDetails");
        }
    }
}
