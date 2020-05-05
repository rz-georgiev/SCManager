using Microsoft.EntityFrameworkCore.Migrations;

namespace HandotaiSeigyo.Data.Migrations
{
    public partial class AttemptTwoToMakeTwoIdentityConnections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_LastIdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_NewIdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypes_LastIdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropIndex(
                name: "IX_UserComponentTypes_NewIdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropColumn(
                name: "LastIdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropColumn(
                name: "NewIdentityUserId",
                table: "UserComponentTypes");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "UserComponentTypeDetails");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByUserId",
                table: "UserComponentTypeDetails");

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
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByIdentityUserId",
                table: "UserComponentTypes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIdentityUserId",
                table: "UserComponentTypeDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByIdentityUserId",
                table: "UserComponentTypeDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIdentityUserId",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByIdentityUserId",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIdentityUserId",
                table: "ComponentTypes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByIdentityUserId",
                table: "ComponentTypes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIdentityUserId",
                table: "ComponentTypeDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByIdentityUserId",
                table: "ComponentTypeDetails",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "UserComponentTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastIdentityUserId",
                table: "UserComponentTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedByUserId",
                table: "UserComponentTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NewIdentityUserId",
                table: "UserComponentTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "UserComponentTypeDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedByUserId",
                table: "UserComponentTypeDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedByUserId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "ComponentTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedByUserId",
                table: "ComponentTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "ComponentTypeDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedByUserId",
                table: "ComponentTypeDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypes_LastIdentityUserId",
                table: "UserComponentTypes",
                column: "LastIdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypes_NewIdentityUserId",
                table: "UserComponentTypes",
                column: "NewIdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_LastIdentityUserId",
                table: "UserComponentTypes",
                column: "LastIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComponentTypes_AspNetUsers_NewIdentityUserId",
                table: "UserComponentTypes",
                column: "NewIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
