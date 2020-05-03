using Microsoft.EntityFrameworkCore.Migrations;

namespace HandotaiSeigyo.Data.Migrations
{
    public partial class RemovedComponentTypeIdTemp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComponentTypeDetails_ComponentTypes_ComponentTypeId",
                table: "ComponentTypeDetails");

            migrationBuilder.AlterColumn<int>(
                name: "ComponentTypeId",
                table: "ComponentTypeDetails",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentTypeDetails_ComponentTypes_ComponentTypeId",
                table: "ComponentTypeDetails",
                column: "ComponentTypeId",
                principalTable: "ComponentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComponentTypeDetails_ComponentTypes_ComponentTypeId",
                table: "ComponentTypeDetails");

            migrationBuilder.AlterColumn<int>(
                name: "ComponentTypeId",
                table: "ComponentTypeDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentTypeDetails_ComponentTypes_ComponentTypeId",
                table: "ComponentTypeDetails",
                column: "ComponentTypeId",
                principalTable: "ComponentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
