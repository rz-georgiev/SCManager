using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class AddedDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComponentTypeDetailId",
                table: "UserComponentTypeDetails",
                nullable: false,
                defaultValue: 0);

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
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
