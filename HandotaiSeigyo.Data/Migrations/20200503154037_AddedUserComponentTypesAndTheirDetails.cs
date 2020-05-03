using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HandotaiSeigyo.Data.Migrations
{
    public partial class AddedUserComponentTypesAndTheirDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserComponentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    LastUpdatedDateTime = table.Column<DateTime>(nullable: false),
                    LastUpdatedByUserId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IdentityUserId = table.Column<int>(nullable: false),
                    ComponentTypeId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    IdentityUserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserComponentTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserComponentTypes_ComponentTypes_ComponentTypeId",
                        column: x => x.ComponentTypeId,
                        principalTable: "ComponentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserComponentTypes_AspNetUsers_IdentityUserId1",
                        column: x => x.IdentityUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserComponentTypeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    LastUpdatedDateTime = table.Column<DateTime>(nullable: false),
                    LastUpdatedByUserId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    UserTypeComponentId = table.Column<int>(nullable: false),
                    ComponentTypeDetailId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    UserComponentTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserComponentTypeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserComponentTypeDetails_ComponentTypeDetails_ComponentTypeDetailId",
                        column: x => x.ComponentTypeDetailId,
                        principalTable: "ComponentTypeDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserComponentTypeDetails_UserComponentTypes_UserComponentTypeId",
                        column: x => x.UserComponentTypeId,
                        principalTable: "UserComponentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypeDetails_ComponentTypeDetailId",
                table: "UserComponentTypeDetails",
                column: "ComponentTypeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypeDetails_UserComponentTypeId",
                table: "UserComponentTypeDetails",
                column: "UserComponentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypes_ComponentTypeId",
                table: "UserComponentTypes",
                column: "ComponentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypes_IdentityUserId1",
                table: "UserComponentTypes",
                column: "IdentityUserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserComponentTypeDetails");

            migrationBuilder.DropTable(
                name: "UserComponentTypes");
        }
    }
}
