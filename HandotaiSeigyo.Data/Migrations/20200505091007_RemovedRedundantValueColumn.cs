using Microsoft.EntityFrameworkCore.Migrations;

namespace HandotaiSeigyo.Data.Migrations
{
    public partial class RemovedRedundantValueColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "ComponentTypeDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "ComponentTypeDetails",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
