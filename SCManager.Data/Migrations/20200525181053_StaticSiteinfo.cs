using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class StaticSiteinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComponentTypeDetails_AspNetUsers_CreatedByIdentityUserId",
                table: "ComponentTypeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ComponentTypeDetails_AspNetUsers_LastUpdatedByIdentityUserId",
                table: "ComponentTypeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ComponentTypes_AspNetUsers_CreatedByIdentityUserId",
                table: "ComponentTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_ComponentTypes_AspNetUsers_LastUpdatedByIdentityUserId",
                table: "ComponentTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_CreatedByIdentityUserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_LastUpdatedByIdentityUserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_UnitMultipliers_AspNetUsers_CreatedByIdentityUserId",
                table: "UnitMultipliers");

            migrationBuilder.DropForeignKey(
                name: "FK_UnitMultipliers_AspNetUsers_LastUpdatedByIdentityUserId",
                table: "UnitMultipliers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypeDetails_AspNetUsers_CreatedByIdentityUserId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypeDetails_AspNetUsers_LastUpdatedByIdentityUserId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_CreatedByIdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_LastUpdatedByIdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypes_CreatedByIdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypes_LastUpdatedByIdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypeDetails_CreatedByIdentityUserId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypeDetails_LastUpdatedByIdentityUserId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropIndex(
                name: "IX_UnitMultipliers_CreatedByIdentityUserId",
                table: "UnitMultipliers");

            migrationBuilder.DropIndex(
                name: "IX_UnitMultipliers_LastUpdatedByIdentityUserId",
                table: "UnitMultipliers");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CreatedByIdentityUserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_LastUpdatedByIdentityUserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_ComponentTypes_CreatedByIdentityUserId",
                table: "ComponentTypes");

            migrationBuilder.DropIndex(
                name: "IX_ComponentTypes_LastUpdatedByIdentityUserId",
                table: "ComponentTypes");

            migrationBuilder.DropIndex(
                name: "IX_ComponentTypeDetails_CreatedByIdentityUserId",
                table: "ComponentTypeDetails");

            migrationBuilder.DropIndex(
                name: "IX_ComponentTypeDetails_LastUpdatedByIdentityUserId",
                table: "ComponentTypeDetails");

            migrationBuilder.DropColumn(
                name: "CreatedByIdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByIdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropColumn(
                name: "CreatedByIdentityUserId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByIdentityUserId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropColumn(
                name: "CreatedByIdentityUserId",
                table: "UnitMultipliers");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByIdentityUserId",
                table: "UnitMultipliers");

            migrationBuilder.DropColumn(
                name: "CreatedByIdentityUserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByIdentityUserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CreatedByIdentityUserId",
                table: "ComponentTypes");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByIdentityUserId",
                table: "ComponentTypes");

            migrationBuilder.DropColumn(
                name: "CreatedByIdentityUserId",
                table: "ComponentTypeDetails");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByIdentityUserId",
                table: "ComponentTypeDetails");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "UserComponentTypes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByUserId",
                table: "UserComponentTypes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "UserComponentTypeDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByUserId",
                table: "UserComponentTypeDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "UnitMultipliers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByUserId",
                table: "UnitMultipliers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByUserId",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "ComponentTypes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByUserId",
                table: "ComponentTypes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "ComponentTypeDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByUserId",
                table: "ComponentTypeDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypes_CreatedByUserId",
                table: "UserComponentTypes",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypes_LastUpdatedByUserId",
                table: "UserComponentTypes",
                column: "LastUpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypeDetails_CreatedByUserId",
                table: "UserComponentTypeDetails",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypeDetails_LastUpdatedByUserId",
                table: "UserComponentTypeDetails",
                column: "LastUpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitMultipliers_CreatedByUserId",
                table: "UnitMultipliers",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitMultipliers_LastUpdatedByUserId",
                table: "UnitMultipliers",
                column: "LastUpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CreatedByUserId",
                table: "Posts",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_LastUpdatedByUserId",
                table: "Posts",
                column: "LastUpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentTypes_CreatedByUserId",
                table: "ComponentTypes",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentTypes_LastUpdatedByUserId",
                table: "ComponentTypes",
                column: "LastUpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentTypeDetails_CreatedByUserId",
                table: "ComponentTypeDetails",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentTypeDetails_LastUpdatedByUserId",
                table: "ComponentTypeDetails",
                column: "LastUpdatedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentTypeDetails_AspNetUsers_CreatedByUserId",
                table: "ComponentTypeDetails",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentTypeDetails_AspNetUsers_LastUpdatedByUserId",
                table: "ComponentTypeDetails",
                column: "LastUpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentTypes_AspNetUsers_CreatedByUserId",
                table: "ComponentTypes",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentTypes_AspNetUsers_LastUpdatedByUserId",
                table: "ComponentTypes",
                column: "LastUpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_CreatedByUserId",
                table: "Posts",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_LastUpdatedByUserId",
                table: "Posts",
                column: "LastUpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnitMultipliers_AspNetUsers_CreatedByUserId",
                table: "UnitMultipliers",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnitMultipliers_AspNetUsers_LastUpdatedByUserId",
                table: "UnitMultipliers",
                column: "LastUpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypeDetails_AspNetUsers_CreatedByUserId",
                table: "UserComponentTypeDetails",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypeDetails_AspNetUsers_LastUpdatedByUserId",
                table: "UserComponentTypeDetails",
                column: "LastUpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_CreatedByUserId",
                table: "UserComponentTypes",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_LastUpdatedByUserId",
                table: "UserComponentTypes",
                column: "LastUpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComponentTypeDetails_AspNetUsers_CreatedByUserId",
                table: "ComponentTypeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ComponentTypeDetails_AspNetUsers_LastUpdatedByUserId",
                table: "ComponentTypeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ComponentTypes_AspNetUsers_CreatedByUserId",
                table: "ComponentTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_ComponentTypes_AspNetUsers_LastUpdatedByUserId",
                table: "ComponentTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_CreatedByUserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_LastUpdatedByUserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_UnitMultipliers_AspNetUsers_CreatedByUserId",
                table: "UnitMultipliers");

            migrationBuilder.DropForeignKey(
                name: "FK_UnitMultipliers_AspNetUsers_LastUpdatedByUserId",
                table: "UnitMultipliers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypeDetails_AspNetUsers_CreatedByUserId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypeDetails_AspNetUsers_LastUpdatedByUserId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_CreatedByUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_LastUpdatedByUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypes_CreatedByUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypes_LastUpdatedByUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypeDetails_CreatedByUserId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypeDetails_LastUpdatedByUserId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropIndex(
                name: "IX_UnitMultipliers_CreatedByUserId",
                table: "UnitMultipliers");

            migrationBuilder.DropIndex(
                name: "IX_UnitMultipliers_LastUpdatedByUserId",
                table: "UnitMultipliers");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CreatedByUserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_LastUpdatedByUserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_ComponentTypes_CreatedByUserId",
                table: "ComponentTypes");

            migrationBuilder.DropIndex(
                name: "IX_ComponentTypes_LastUpdatedByUserId",
                table: "ComponentTypes");

            migrationBuilder.DropIndex(
                name: "IX_ComponentTypeDetails_CreatedByUserId",
                table: "ComponentTypeDetails");

            migrationBuilder.DropIndex(
                name: "IX_ComponentTypeDetails_LastUpdatedByUserId",
                table: "ComponentTypeDetails");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByUserId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "UnitMultipliers");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByUserId",
                table: "UnitMultipliers");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByUserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "ComponentTypes");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByUserId",
                table: "ComponentTypes");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "ComponentTypeDetails");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByUserId",
                table: "ComponentTypeDetails");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIdentityUserId",
                table: "UserComponentTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByIdentityUserId",
                table: "UserComponentTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIdentityUserId",
                table: "UserComponentTypeDetails",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByIdentityUserId",
                table: "UserComponentTypeDetails",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIdentityUserId",
                table: "UnitMultipliers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByIdentityUserId",
                table: "UnitMultipliers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIdentityUserId",
                table: "Posts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByIdentityUserId",
                table: "Posts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIdentityUserId",
                table: "ComponentTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByIdentityUserId",
                table: "ComponentTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIdentityUserId",
                table: "ComponentTypeDetails",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByIdentityUserId",
                table: "ComponentTypeDetails",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypes_CreatedByIdentityUserId",
                table: "UserComponentTypes",
                column: "CreatedByIdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypes_LastUpdatedByIdentityUserId",
                table: "UserComponentTypes",
                column: "LastUpdatedByIdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypeDetails_CreatedByIdentityUserId",
                table: "UserComponentTypeDetails",
                column: "CreatedByIdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypeDetails_LastUpdatedByIdentityUserId",
                table: "UserComponentTypeDetails",
                column: "LastUpdatedByIdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitMultipliers_CreatedByIdentityUserId",
                table: "UnitMultipliers",
                column: "CreatedByIdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitMultipliers_LastUpdatedByIdentityUserId",
                table: "UnitMultipliers",
                column: "LastUpdatedByIdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CreatedByIdentityUserId",
                table: "Posts",
                column: "CreatedByIdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_LastUpdatedByIdentityUserId",
                table: "Posts",
                column: "LastUpdatedByIdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentTypes_CreatedByIdentityUserId",
                table: "ComponentTypes",
                column: "CreatedByIdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentTypes_LastUpdatedByIdentityUserId",
                table: "ComponentTypes",
                column: "LastUpdatedByIdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentTypeDetails_CreatedByIdentityUserId",
                table: "ComponentTypeDetails",
                column: "CreatedByIdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentTypeDetails_LastUpdatedByIdentityUserId",
                table: "ComponentTypeDetails",
                column: "LastUpdatedByIdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentTypeDetails_AspNetUsers_CreatedByIdentityUserId",
                table: "ComponentTypeDetails",
                column: "CreatedByIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentTypeDetails_AspNetUsers_LastUpdatedByIdentityUserId",
                table: "ComponentTypeDetails",
                column: "LastUpdatedByIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentTypes_AspNetUsers_CreatedByIdentityUserId",
                table: "ComponentTypes",
                column: "CreatedByIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentTypes_AspNetUsers_LastUpdatedByIdentityUserId",
                table: "ComponentTypes",
                column: "LastUpdatedByIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_CreatedByIdentityUserId",
                table: "Posts",
                column: "CreatedByIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_LastUpdatedByIdentityUserId",
                table: "Posts",
                column: "LastUpdatedByIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_UserComponentTypeDetails_AspNetUsers_CreatedByIdentityUserId",
                table: "UserComponentTypeDetails",
                column: "CreatedByIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypeDetails_AspNetUsers_LastUpdatedByIdentityUserId",
                table: "UserComponentTypeDetails",
                column: "LastUpdatedByIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_CreatedByIdentityUserId",
                table: "UserComponentTypes",
                column: "CreatedByIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_LastUpdatedByIdentityUserId",
                table: "UserComponentTypes",
                column: "LastUpdatedByIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
