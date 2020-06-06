using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class BeautifiedComponentTypesAndTheirDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "ComponentTypes");

            migrationBuilder.AddColumn<string>(
                name: "ImageId",
                table: "ComponentTypes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "ComponentTypes");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "ComponentTypes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
