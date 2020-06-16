using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class RefactoredComponentValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "UserComponentTypes");

            migrationBuilder.AddColumn<float>(
                name: "Value",
                table: "UserComponentTypeDetails",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "UserComponentTypeDetails");

            migrationBuilder.AddColumn<float>(
                name: "Value",
                table: "UserComponentTypes",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
