using Microsoft.EntityFrameworkCore.Migrations;

namespace HandotaiSeigyo.Data.Migrations
{
    public partial class AddedUnitMultipliers2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnitMultiplier_AspNetUsers_CreatedByIdentityUserId",
                table: "UnitMultiplier");

            migrationBuilder.DropForeignKey(
                name: "FK_UnitMultiplier_AspNetUsers_LastUpdatedByIdentityUserId",
                table: "UnitMultiplier");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypeDetails_UnitMultiplier_UnitMultiplierId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnitMultiplier",
                table: "UnitMultiplier");

            migrationBuilder.RenameTable(
                name: "UnitMultiplier",
                newName: "UnitMultipliers");

            migrationBuilder.RenameIndex(
                name: "IX_UnitMultiplier_LastUpdatedByIdentityUserId",
                table: "UnitMultipliers",
                newName: "IX_UnitMultipliers_LastUpdatedByIdentityUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UnitMultiplier_CreatedByIdentityUserId",
                table: "UnitMultipliers",
                newName: "IX_UnitMultipliers_CreatedByIdentityUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnitMultipliers",
                table: "UnitMultipliers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnitMultipliers_AspNetUsers_CreatedByIdentityUserId",
                table: "UnitMultipliers",
                column: "CreatedByIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnitMultipliers_AspNetUsers_LastUpdatedByIdentityUserId",
                table: "UnitMultipliers",
                column: "LastUpdatedByIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypeDetails_UnitMultipliers_UnitMultiplierId",
                table: "UserComponentTypeDetails",
                column: "UnitMultiplierId",
                principalTable: "UnitMultipliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnitMultipliers_AspNetUsers_CreatedByIdentityUserId",
                table: "UnitMultipliers");

            migrationBuilder.DropForeignKey(
                name: "FK_UnitMultipliers_AspNetUsers_LastUpdatedByIdentityUserId",
                table: "UnitMultipliers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypeDetails_UnitMultipliers_UnitMultiplierId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnitMultipliers",
                table: "UnitMultipliers");

            migrationBuilder.RenameTable(
                name: "UnitMultipliers",
                newName: "UnitMultiplier");

            migrationBuilder.RenameIndex(
                name: "IX_UnitMultipliers_LastUpdatedByIdentityUserId",
                table: "UnitMultiplier",
                newName: "IX_UnitMultiplier_LastUpdatedByIdentityUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UnitMultipliers_CreatedByIdentityUserId",
                table: "UnitMultiplier",
                newName: "IX_UnitMultiplier_CreatedByIdentityUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnitMultiplier",
                table: "UnitMultiplier",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnitMultiplier_AspNetUsers_CreatedByIdentityUserId",
                table: "UnitMultiplier",
                column: "CreatedByIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnitMultiplier_AspNetUsers_LastUpdatedByIdentityUserId",
                table: "UnitMultiplier",
                column: "LastUpdatedByIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypeDetails_UnitMultiplier_UnitMultiplierId",
                table: "UserComponentTypeDetails",
                column: "UnitMultiplierId",
                principalTable: "UnitMultiplier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
