using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class ComponentTypeDetail_From_UserComponentTypeDetail_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypeDetails_ComponentTypeDetails_ComponentTypeDetailId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypeDetails_ComponentTypeDetailId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropColumn(
                name: "ComponentTypeDetailId",
                table: "UserComponentTypeDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComponentTypeDetailId",
                table: "UserComponentTypeDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypeDetails_ComponentTypeDetailId",
                table: "UserComponentTypeDetails",
                column: "ComponentTypeDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypeDetails_ComponentTypeDetails_ComponentTypeDetailId",
                table: "UserComponentTypeDetails",
                column: "ComponentTypeDetailId",
                principalTable: "ComponentTypeDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
