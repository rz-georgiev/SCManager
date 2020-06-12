using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class ValueFromStringToFloat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Value",
                table: "UserComponentTypeDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "UserComponentTypeDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(float));
        }
    }
}
