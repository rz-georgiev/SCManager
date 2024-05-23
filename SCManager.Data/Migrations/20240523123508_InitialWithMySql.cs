using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SCManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialWithMySql : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImageId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastUpdatedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastUpdatedByUserId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsBanned = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AspNetUsers_LastUpdatedByUserId",
                        column: x => x.LastUpdatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ComponentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImageId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastUpdatedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastUpdatedByUserId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComponentTypes_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComponentTypes_AspNetUsers_LastUpdatedByUserId",
                        column: x => x.LastUpdatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StaticSiteInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastUpdatedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastUpdatedByUserId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaticSiteInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaticSiteInfos_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaticSiteInfos_AspNetUsers_LastUpdatedByUserId",
                        column: x => x.LastUpdatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UnitMultipliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastUpdatedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastUpdatedByUserId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitMultipliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitMultipliers_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitMultipliers_AspNetUsers_LastUpdatedByUserId",
                        column: x => x.LastUpdatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ComponentTypeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Unit = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Symbol = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ComponentTypeId = table.Column<int>(type: "int", nullable: false),
                    IsPrimary = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastUpdatedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastUpdatedByUserId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentTypeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComponentTypeDetails_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComponentTypeDetails_AspNetUsers_LastUpdatedByUserId",
                        column: x => x.LastUpdatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ComponentTypeDetails_ComponentTypes_ComponentTypeId",
                        column: x => x.ComponentTypeId,
                        principalTable: "ComponentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserComponentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ComponentTypeId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastUpdatedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastUpdatedByUserId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserComponentTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserComponentTypes_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserComponentTypes_AspNetUsers_LastUpdatedByUserId",
                        column: x => x.LastUpdatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserComponentTypes_ComponentTypes_ComponentTypeId",
                        column: x => x.ComponentTypeId,
                        principalTable: "ComponentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserComponentTypeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<float>(type: "float", nullable: false),
                    UserComponentTypeId = table.Column<int>(type: "int", nullable: false),
                    UnitMultiplierId = table.Column<int>(type: "int", nullable: false),
                    ComponentTypeDetailId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastUpdatedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastUpdatedByUserId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserComponentTypeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserComponentTypeDetails_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserComponentTypeDetails_AspNetUsers_LastUpdatedByUserId",
                        column: x => x.LastUpdatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserComponentTypeDetails_ComponentTypeDetails_ComponentTypeD~",
                        column: x => x.ComponentTypeDetailId,
                        principalTable: "ComponentTypeDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserComponentTypeDetails_UnitMultipliers_UnitMultiplierId",
                        column: x => x.UnitMultiplierId,
                        principalTable: "UnitMultipliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserComponentTypeDetails_UserComponentTypes_UserComponentTyp~",
                        column: x => x.UserComponentTypeId,
                        principalTable: "UserComponentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37152c28-98e0-4067-93eb-f708a463d91b", "514f4df7-f0a4-4b34-aaf8-54c4c874f824", "User", "USER" },
                    { "c5fb4568-51c6-43ab-8050-a5642eb9ac44", "55309049-c467-42fd-9223-e221b7c3b61a", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDateTime", "Email", "EmailConfirmed", "ImageId", "IsBanned", "LastUpdatedByUserId", "LastUpdatedDateTime", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7b26038d-1a43-4248-90e1-dc7f0381d7fa", 0, "53ea6bca-6c80-400c-9cb5-ac31d508a7f7", new DateTime(2020, 6, 1, 14, 57, 16, 395, DateTimeKind.Unspecified).AddTicks(9967), "scmanager_test@mail.com", true, null, false, null, null, true, null, "SCMANAGER_TEST@MAIL.COM", "SCMANAGER_TEST@MAIL.COM", "AQAAAAEAACcQAAAAEM9A4bvt/Ci2fC2r5Si1p2dEX8/v8/svgQqI1rqocSOUcWqgfzD8A8OGlpU/6qiZbQ==", null, false, "UFEWI655NFJHSNPMEJBEGWHAJKHAVWIW", false, "scmanager_test@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c5fb4568-51c6-43ab-8050-a5642eb9ac44", "7b26038d-1a43-4248-90e1-dc7f0381d7fa" });

            migrationBuilder.InsertData(
                table: "ComponentTypes",
                columns: new[] { "Id", "CreatedByUserId", "CreatedDateTime", "ImageId", "IsActive", "LastUpdatedByUserId", "LastUpdatedDateTime", "Name" },
                values: new object[,]
                {
                    { 1, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 9, 4, 56, 317, DateTimeKind.Utc), "ppslaiahjrh2k4epp0em", true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2022, 8, 25, 8, 35, 36, 253, DateTimeKind.Utc), "DIAC" },
                    { 2, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 9, 19, 20, 856, DateTimeKind.Utc), "psu7wqx9un5h0ecgddwo", true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2022, 8, 25, 8, 35, 31, 182, DateTimeKind.Utc), "Diode" },
                    { 3, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 9, 24, 55, 905, DateTimeKind.Utc), "gtspjkchcrw7mdkp3g8p", true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2022, 8, 25, 8, 34, 58, 328, DateTimeKind.Utc), "Laser diode" },
                    { 4, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 10, 18, 36, 643, DateTimeKind.Utc), "w4f8lrhjwbjvshjvbtls", true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2022, 8, 25, 8, 36, 10, 700, DateTimeKind.Utc), "Bipolar transistor" },
                    { 5, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 11, 15, 2, 6, DateTimeKind.Utc), "qg5kdtsz0b3raaieupn9", true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2022, 8, 25, 8, 33, 24, 429, DateTimeKind.Utc), "Resistor Carbon Film" },
                    { 6, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 11, 16, 31, 944, DateTimeKind.Utc), "byl38nu7etykfflshph4", true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2022, 8, 25, 8, 36, 14, 378, DateTimeKind.Utc), " Multilayer Ceramic Capacitor" },
                    { 7, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 11, 39, 51, 852, DateTimeKind.Utc), "on5w03cgmaxtjdpowx6u", true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2022, 8, 25, 8, 34, 25, 664, DateTimeKind.Utc), "Rectifier Bridge" },
                    { 8, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 11, 41, 41, 536, DateTimeKind.Utc), "gy5xinh33xuvudsjoymt", true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2022, 8, 25, 8, 32, 45, 16, DateTimeKind.Utc), "Rotary Potentiometer" },
                    { 9, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 11, 43, 25, 949, DateTimeKind.Utc), "joddlvezkathultkecba", true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2022, 8, 25, 8, 35, 44, 416, DateTimeKind.Utc), "Crystal Oscillator" },
                    { 10, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 11, 54, 13, 960, DateTimeKind.Utc), "xia5f5av9rtuj2yjhoob", true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2022, 8, 25, 8, 35, 3, 970, DateTimeKind.Utc), "Glass Fuse" },
                    { 11, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 11, 57, 27, 786, DateTimeKind.Utc), "ilwnn0qvpbgob53erzgn", true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2022, 8, 25, 8, 32, 18, 600, DateTimeKind.Utc), "Transformer ANG" },
                    { 12, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 11, 58, 42, 336, DateTimeKind.Utc), "ugzoc5indiz4bmebmzev", true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2022, 8, 25, 8, 34, 54, 539, DateTimeKind.Utc), "Push Button Switch" },
                    { 13, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 11, 59, 54, 289, DateTimeKind.Utc), "owq3kujl3asj9as0aw0f", true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2022, 8, 25, 8, 33, 29, 600, DateTimeKind.Utc), "Relay" }
                });

            migrationBuilder.InsertData(
                table: "StaticSiteInfos",
                columns: new[] { "Id", "Content", "CreatedByUserId", "CreatedDateTime", "IsActive", "LastUpdatedByUserId", "LastUpdatedDateTime", "Name" },
                values: new object[,]
                {
                    { 5, "<h3 style=\"margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);\">Name</h3>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">SCManager</p>\r\n<h3 style=\"margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);\">Description</h3>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">SCManager is a semiconductors management application, that is directed for usage by electronics and electrician specialists, so they can keep track of what components they have in stash.</p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color:rgba(255, 255, 255, 1);\">It can also be used in some warehouses/repair shops.</p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><span style=\"color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, Segoe UI, Roboto, Oxygen, Ubuntu, Cantarell, Fira Sans, Droid Sans, Helvetica Neue, Helvetica, Arial, sans-serif;\">Project github url:&nbsp;</span><a href=\"https://github.com/rz-georgiev/SCManager\">https://github.com/rz-georgiev/SCManager</a></p>\r\n<h3 style=\"margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);\">About</h3>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">This project will be used as a <strong>diploma work</strong> and for a <strong>CV upgrade.</strong></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">Supervisor: Associate Professor Dr. Lyudmila Dimitrova</p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1);\"><span style=\"color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, Segoe UI, Roboto, Oxygen, Ubuntu, Cantarell, Fira Sans, Droid Sans, Helvetica Neue, Helvetica, Arial, sans-serif;\">Head of a master's program:&nbsp;</span><span style=\"color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px;\">Associate Professor Dr.</span><span style=\"color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px;\">&nbsp;Stanislav Simeonov</span></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><span style=\"color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px;\">Head of department:&nbsp;</span><span style=\"color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px;\">Associate Professor Dr.</span><span style=\"color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px;\">&nbsp;Veselina Bureva</span></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><span style=\"color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px;\">Graduate: Radoslav Georgiev</span></p>\r\n<h3 style=\"margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);\">Installation</h3>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">Download the project and start the solution.</p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">Create a profile and get a private key from&nbsp;<a style=\"font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;\" href=\"https://sendgrid.com/\">https://sendgrid.com/</a></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">Create a profile and get a private key from <a style=\"font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;\" href=\"https://cloudinary.com/\">https://cloudinary.com/</a></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">Now replace these keys in your appsettings.json file.</p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">The application will automatically apply the migrations and the sample data seeding for you, so just build and run the solution.</p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><span style=\"color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, Segoe UI, Roboto, Oxygen, Ubuntu, Cantarell, Fira Sans, Droid Sans, Helvetica Neue, Helvetica, Arial, sans-serif;\">Note: First launch can be a little bit slow, because of the database creation and the data seeding.</span></p>\r\n<h3 style=\"margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);\">Technologies:</h3>\r\n<p><span style=\"color: rgba(52, 73, 94, 1);\">* .NET Core 3.1</span></p>\r\n<p><span style=\"color: rgba(52, 73, 94, 1);\">* Entity Framework Core</span></p>\r\n<p><span style=\"color: rgba(52, 73, 94, 1);\">* AutoMapper</span></p>\r\n<p><span style=\"color: rgba(52, 73, 94, 1);\">* BuildBundlerMinifier</span></p>\r\n<p><span style=\"color: rgba(52, 73, 94, 1);\">* Cloudinary.Core</span></p>\r\n<p><span style=\"color: rgba(52, 73, 94, 1);\">* HtmlSanitizer</span></p>\r\n<p><span style=\"color: rgba(52, 73, 94, 1);\">* Bootstrap</span></p>\r\n<p><span style=\"color: rgba(52, 73, 94, 1);\">* SendGrid</span></p>\r\n<p><span style=\"color: rgba(52, 73, 94, 1);\">* Chart.js</span></p>\r\n<p><span style=\"color: rgba(52, 73, 94, 1);\">* Datatables.js</span></p>\r\n<p><span style=\"color: rgba(52, 73, 94, 1);\">* JQuery</span></p>\r\n<p><span style=\"color: rgba(52, 73, 94, 1);\">* ML.NET for the Bayesian analysis</span></p>\r\n<h3 style=\"margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);\">Features</h3>\r\n<p><span style=\"color: rgba(52, 73, 94, 1);\">* Enabled ASP.NET Core Identity authentication [extended via ApplicationUser class]</span></p>\r\n<p><span style=\"color: rgba(52, 73, 94, 1);\">* Enabled auto-generation of antiforgery token for each post request.</span></p>\r\n<p><span style=\"color: rgba(52, 73, 94, 1);\">* Enabled by default - protection from XSS attacks via the HTML Razor symbol escape operations</span></p>\r\n<h3 style=\"margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125;\">Usage</h3>\r\n<p><strong style=\"color: rgba(74, 74, 74, 1);\">User profile:</strong></p>\r\n<p><span style=\"color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">You can change your profile picture, email and password.</span></p>\r\n<p><span style=\"color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">You can also download your personal data in a .json file format.</span></p>\r\n<p><span style=\"color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">There is a option to delete your account and all related data to it.</span></p>\r\n<p><span style=\"color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">In the Two-factor authentication tab, you can configure an authenticator app via a QR code or a private key, so when you login, you will have an additional layer of security.</span></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); background-color: rgba(255, 255, 255, 1);\"><strong>Dashboard: </strong></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">You can see how many components you have in total of each type and what percentage it takes from the total components count [via a progress bar].</p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">In the top right of the progress bar there is a total price for all the components of the type.</p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">In the bottom there is a chart which shows you also the total price for each component type.</p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><strong>My components:</strong></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">Here you can add a new component and fill it with Quantites, Unit price and all other properties associated with it.</p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubun tu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">Also you can see in a nice card menu all components you have and their basic information.</p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><strong>Bayesian analysis TODO:</strong></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">###</p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><strong>Admin panel:</strong></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">Displayed in a neat fully functional tables, you can manage the Users roles,</p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); background-color: rgba(255, 255, 255, 1);\">create/edit component types, create/edit unit multipliers and also edit the site Privacy and About tabs information.</p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">To see and use the Admin panel you need to authorized and have the according roles [\"Administrator\"].</p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><strong>Privacy policy:</strong></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">There you can read all needed information about the GDPR agreements and your user rights. [Theres is an GDPR agreement option when you first visit the website].</p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><strong>About:&nbsp;</strong></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">Well, this is the page you are currently reading.</p>\r\n<h3 style=\"margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);\">Support</h3>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">Post your questions to scmanager_test[at]mail[dot]com</p>\r\n<h3 style=\"margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);\">Contributing</h3>\r\n<p><span style=\"color: rgba(52, 73, 94, 1);\">Just copy the project a nd have fun</span></p>\r\n<h3 style=\"margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);\">Authors and acknowledgment</h3>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><span style=\"color: rgba(52, 73, 94, 1);\">Special thanks to:</span></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><a href=\"https://www.microsoft.com/en-us\">https://www.microsoft.com/en-us</a></p>\r\n<p style=\"margin: 1em 0 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><a href=\"https://startbootstrap.com/themes/sb-admin-2/\">https://startbootstrap.com/themes/sb-admin-2/</a></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><a href=\"https://github.com/StartBootstrap/startbootstrap-sb-admin-2\">https://github.com/StartBootstrap/startbootstrap-sb-admin-2</a></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><a style=\"font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;\" href=\"https://sendgrid.com/\">https://sendgrid.com/</a></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><a style=\"font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;\" href=\"https://cloudinary.com/\">https://cloudinary.com/</a></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxyg en, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><a href=\"https://github.com/mganss/HtmlSanitizer\">https://github.com/mganss/HtmlSanitizer</a></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1);\"><a href=\"https://www.chartjs.org/\">https://www.chartjs.org/</a></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><a href=\"https://datatables.net/\">https://datatables.net/</a></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><a href=\"https://fontawesome.com/\">https://fontawesome.com/</a></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><a href=\"https://www.tiny.cloud/\">https://www.tiny.cloud/</a></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><a href=\"https://jquery.com/\">https://jquery.com/</a></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); background-color: rgba(255, 255, 255, 1);\"><a href=\"https://getbootstrap.com/\">https://getbootstrap.com/</a></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); background-color: rgba(255, 255, 255, 1);\"><a href=\"https://www.freepik.com/free-photos-vectors/web-banner\">https://www.freepik.com/free-photos-vectors/web-banner</a></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); background-color: rgba(255, 255, 255, 1);\"><a href=\"https://undraw.co/illustrations\">https://undraw.co/illustrations</a></p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">Me: R. Georgiev</p>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\">&nbsp;</p>\r\n<h3 style=\"margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);\">License</h3>\r\n<pre style=\"overflow: auto; font-family: Consolas, Monaco, Courier, monospace; font-size: 14px; background-color: rgba(255, 255, 255, 1); border: 1px solid rgba(238, 238, 238, 1); border-radius: 3px; padding: 20px; color: rgba(92, 88, 85, 1);\">MIT License\r\n\r\nCopyright (c) [2020] [SCManager]\r\n\r\nPermission is hereby granted, free of charge, to any person obtaining a copy\r\nof this software and associated documentation files (the \"Software\"), to deal\r\nin the Software without restric\r\ntion, including without limitation the rights\r\nto use, copy, modify, merge, publish, distribute, sublicense, and/or sell\r\ncopies of the Software, and to permit persons to whom the Software is\r\nfurnished to do so\r\n, subject to the following conditions:\r\n\r\nThe above copyright notice and this permission notice shall be included in all\r\ncopies or substantial portions of the Software.\r\n\r\nTHE SOFTWARE IS PROVIDED \"AS IS\",WITHOUT WARRANTY OF ANY KIND, EXPRESS OR\r\nIMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,\r\nFITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE\r\nAUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER\r\nLIABILITY, WHETHE\r\nR IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,\r\nOUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE\r\nSOFTWARE.</pre>\r\n<h3 style=\"margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);\">Project status</h3>\r\n<p style=\"margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);\"><span style=\"color: rgba(52, 73, 94, 1);\">Currently in development.</span></p>", "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 33, 13, 892, DateTimeKind.Unspecified).AddTicks(3650), "About" },
                    { 6, "<p>Your privacy is important to us. It is SCManager's policy to respect your privacy regarding any information we may collect from you across our website, <a href=\"http://www.scmanager.com/\">http://www.scmanager.com/</a>, and other sites we\r\n own and operate.</p>\r\n<p>We only ask for personal information when we truly need it to provide a service to you. We collect it by fair and lawful means, with your knowledge and consent. We also let you know why we&rsquo;re collecting it and how it will be used.</p>\r\n<p>We only retain collected information for as long as necessary to provide you with your requested service. What data we store, we&rsquo;ll protect within commercially acceptable means to prevent loss and theft, as well as unauthorized access, disclosure, copying, use or modification.</p>\r\n<p>We don&rsquo;t share any personally identifying information publicly or with third-parties, ex\r\ncept when required to by law.</p>\r\n<p>Our website may link to external sites that are not operated by us. Please be aware that we have no control over the content and practices of these sites, and cannot accept responsibility or liability for their respective privacy policies.</p>\r\n<p>You are free to refuse our request for your personal information, with the understanding that we may be unable to provide you with some of your desired services.</p>\r\n<p>Your continued use of our website will be regarded as acceptance of our practices around privacy and persona\r\nl information. If you have any questions about how we handle user data and personal information, feel free to contact us.</p>\r\n<p>&nbsp;</p>\r\n<p>This policy is effective as of 2 June 2020.</p>\r\n<p>&nbsp;</p>\r\n<p>Best regards,</p>\r\n<p>The SCManager team</p>\r\n<p>&nbsp;</p>\r\n<p><a title=\"Generate a free privacy policy\" href=\"https://getterms.io\">Privacy Policy created with GetTerms.</a></p>", "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "Privacy" }
                });

            migrationBuilder.InsertData(
                table: "UnitMultipliers",
                columns: new[] { "Id", "CreatedByUserId", "CreatedDateTime", "IsActive", "LastUpdatedByUserId", "LastUpdatedDateTime", "Name" },
                values: new object[,]
                {
                    { 1, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 12, 27, 55, 67, DateTimeKind.Unspecified).AddTicks(1817), true, null, null, " " },
                    { 2, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 12, 43, 59, 239, DateTimeKind.Unspecified).AddTicks(5842), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 12, 57, 50, 214, DateTimeKind.Unspecified).AddTicks(2519), "G" },
                    { 3, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 12, 45, 38, 708, DateTimeKind.Unspecified).AddTicks(5628), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 12, 57, 57, 72, DateTimeKind.Unspecified).AddTicks(7780), "M" },
                    { 6, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 12, 58, 50, 814, DateTimeKind.Unspecified).AddTicks(2703), true, null, null, "k" },
                    { 7, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 12, 59, 14, 934, DateTimeKind.Unspecified).AddTicks(1223), true, null, null, "m" },
                    { 8, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 12, 59, 39, 612, DateTimeKind.Unspecified).AddTicks(532), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 14, 18, 52, 200, DateTimeKind.Unspecified).AddTicks(5528), "μ" },
                    { 9, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 12, 59, 48, 972, DateTimeKind.Unspecified).AddTicks(5855), true, null, null, "p" },
                    { 10, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 12, 59, 51, 939, DateTimeKind.Unspecified).AddTicks(9064), true, null, null, "n" }
                });

            migrationBuilder.InsertData(
                table: "ComponentTypeDetails",
                columns: new[] { "Id", "ComponentTypeId", "CreatedByUserId", "CreatedDateTime", "IsActive", "IsPrimary", "LastUpdatedByUserId", "LastUpdatedDateTime", "Name", "Symbol", "Unit" },
                values: new object[,]
                {
                    { 1, 11, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 7, 40, 979, DateTimeKind.Unspecified).AddTicks(4689), true, true, null, null, "Input Voltage", "VAC", "Volt Amper" },
                    { 2, 11, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 8, 1, 58, DateTimeKind.Unspecified).AddTicks(9372), true, false, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 8, 10, 368, DateTimeKind.Unspecified).AddTicks(8734), "Output Voltage", "V", "Volt" },
                    { 3, 11, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 8, 39, 765, DateTimeKind.Unspecified).AddTicks(4909), true, false, null, null, "Current Rating", "A", "Amper" },
                    { 4, 8, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 9, 14, 769, DateTimeKind.Unspecified).AddTicks(5434), true, true, null, null, "Resistance", "Ω", "Ohm" },
                    { 5, 8, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 9, 44, 530, DateTimeKind.Unspecified).AddTicks(3046), true, false, null, null, "Number of Channels", "C", "Count" },
                    { 6, 5, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 10, 16, 654, DateTimeKind.Unspecified).AddTicks(2810), true, true, null, null, "Resistance", "Ω", "Ohms" },
                    { 7, 5, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 10, 31, 327, DateTimeKind.Unspecified).AddTicks(3702), true, false, null, null, "Tolerance", "%", "Percents" },
                    { 8, 5, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 10, 45, 824, DateTimeKind.Unspecified).AddTicks(6415), true, false, null, null, "Power", "W", "Watt" },
                    { 9, 5, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 10, 56, 855, DateTimeKind.Unspecified).AddTicks(3270), true, false, null, null, "Voltage Rating", "V", "Volt" },
                    { 10, 13, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 11, 22, 912, DateTimeKind.Unspecified).AddTicks(8416), true, true, null, null, "Coil Voltage", "V", "Volt" },
                    { 11, 13, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 11, 37, 726, DateTimeKind.Unspecified).AddTicks(3168), true, false, null, null, "Coil Resistance", "Ω", "Ohms" },
                    { 12, 13, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 11, 49, 814, DateTimeKind.Unspecified).AddTicks(8223), true, false, null, null, "Coil Power", "W", "Watt" },
                    { 13, 7, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 12, 19, 618, DateTimeKind.Unspecified).AddTicks(2994), true, true, null, null, "Forward Current If /AV/", "A", "Ampers" },
                    { 14, 7, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 12, 28, 309, DateTimeKind.Unspecified).AddTicks(6373), true, false, null, null, "Forward Voltage Vf Max", "V", "Volt" },
                    { 15, 12, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 12, 52, 495, DateTimeKind.Unspecified).AddTicks(1972), true, true, null, null, "Max Voltage", "V", "Volts" },
                    { 16, 12, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 13, 2, 538, DateTimeKind.Unspecified).AddTicks(1600), true, false, null, null, "Max Current", "A", "Ampers" },
                    { 17, 12, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 13, 15, 894, DateTimeKind.Unspecified).AddTicks(8340), true, false, null, null, "Mounting size", "mm", "Millimeters" },
                    { 18, 3, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 13, 57, 995, DateTimeKind.Unspecified).AddTicks(4232), true, true, null, null, "Wave Length", "mm", "Millimeters" },
                    { 19, 3, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 14, 5, 311, DateTimeKind.Unspecified).AddTicks(9404), true, false, null, null, "Power", "W", "Watt" },
                    { 20, 10, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 14, 29, 838, DateTimeKind.Unspecified).AddTicks(7786), true, true, null, null, "Voltage AC", "V", "Volts" },
                    { 21, 10, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 14, 39, 527, DateTimeKind.Unspecified).AddTicks(4307), true, false, null, null, "Current Rating", "A", "Ampers" },
                    { 22, 10, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 14, 49, 111, DateTimeKind.Unspecified).AddTicks(3104), true, false, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 15, 15, 984, DateTimeKind.Unspecified).AddTicks(2547), "Operating Temperature", "℃", "Degrees" },
                    { 23, 10, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 14, 59, 713, DateTimeKind.Unspecified).AddTicks(1836), true, false, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 15, 13, 370, DateTimeKind.Unspecified).AddTicks(4723), "Temperature /wave/", "℃", "Degrees" },
                    { 24, 2, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 15, 50, 318, DateTimeKind.Unspecified).AddTicks(9733), true, true, null, null, "Forward Current If /AV/", "A", "Ampers" },
                    { 25, 2, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 15, 57, 181, DateTimeKind.Unspecified).AddTicks(6481), true, false, null, null, "Forward Voltage Vf Max", "V", "Volts" },
                    { 26, 2, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 16, 6, 461, DateTimeKind.Unspecified).AddTicks(7533), true, false, null, null, "Number of Pins", "C", "Count" },
                    { 27, 1, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 16, 30, 990, DateTimeKind.Unspecified).AddTicks(7588), true, true, null, null, "I trm", "A", "Ampers" },
                    { 28, 1, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 16, 41, 422, DateTimeKind.Unspecified).AddTicks(6665), true, false, null, null, "Vbo", "V", "Volts" },
                    { 29, 1, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 16, 51, 77, DateTimeKind.Unspecified).AddTicks(8112), true, false, null, null, "Power", "W", "Watt" },
                    { 30, 1, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 17, 1, 534, DateTimeKind.Unspecified).AddTicks(9713), true, false, null, null, "Number of Pins", "C", "Count" },
                    { 31, 1, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 17, 12, 822, DateTimeKind.Unspecified).AddTicks(2673), true, false, null, null, "Body Diameter", "mm", "Millimeters" },
                    { 32, 1, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 17, 22, 647, DateTimeKind.Unspecified).AddTicks(9152), true, false, null, null, "Mounting", "L", "Leads" },
                    { 33, 1, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 17, 33, 654, DateTimeKind.Unspecified).AddTicks(945), true, false, null, null, "Case Style", "S", "Style" },
                    { 34, 4, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 18, 4, 647, DateTimeKind.Unspecified).AddTicks(4141), true, true, null, null, "Uceo /Max/", "V", "Volts" },
                    { 35, 4, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 18, 12, 157, DateTimeKind.Unspecified).AddTicks(717), true, false, null, null, "Ucbo", "V", "Volts" },
                    { 36, 4, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 18, 19, 701, DateTimeKind.Unspecified).AddTicks(5422), true, false, null, null, "Ic /Max/", "A", "Ampers" },
                    { 37, 4, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 18, 29, 307, DateTimeKind.Unspecified).AddTicks(9295), true, false, null, null, "Frequency", "Hz", "Hertz" },
                    { 38, 6, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 19, 29, 222, DateTimeKind.Unspecified).AddTicks(7478), true, true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 19, 56, 807, DateTimeKind.Unspecified).AddTicks(2235), "Capacitance", "F", "Farads" },
                    { 39, 6, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 19, 39, 833, DateTimeKind.Unspecified).AddTicks(4955), true, false, null, null, "Tolerance", "%", "Percents" },
                    { 40, 6, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 19, 46, 85, DateTimeKind.Unspecified).AddTicks(804), true, false, null, null, "Max Voltage", "V", "Volts" },
                    { 41, 9, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 21, 59, 3, DateTimeKind.Unspecified).AddTicks(2010), true, true, null, null, "Frequency", "Hz", "Hertz" }
                });

            migrationBuilder.InsertData(
                table: "UserComponentTypes",
                columns: new[] { "Id", "ComponentTypeId", "CreatedByUserId", "CreatedDateTime", "IsActive", "LastUpdatedByUserId", "LastUpdatedDateTime", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 26, 28, 618, DateTimeKind.Unspecified).AddTicks(6808), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 29, 4, 40, DateTimeKind.Unspecified).AddTicks(4024), 10, 12.50m },
                    { 2, 5, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 24, 180, DateTimeKind.Unspecified).AddTicks(4903), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 36, 180, DateTimeKind.Unspecified).AddTicks(413), 50, 1.30m },
                    { 3, 13, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 53, 939, DateTimeKind.Unspecified).AddTicks(6660), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 0, 58, DateTimeKind.Unspecified).AddTicks(3159), 5, 3.58m },
                    { 4, 10, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 18, 392, DateTimeKind.Unspecified).AddTicks(9670), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 26, 858, DateTimeKind.Unspecified).AddTicks(6889), 14, 0.63m },
                    { 5, 9, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 41, 437, DateTimeKind.Unspecified).AddTicks(1875), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 50, 520, DateTimeKind.Unspecified).AddTicks(2216), 60, 8.50m }
                });

            migrationBuilder.InsertData(
                table: "UserComponentTypeDetails",
                columns: new[] { "Id", "ComponentTypeDetailId", "CreatedByUserId", "CreatedDateTime", "IsActive", "LastUpdatedByUserId", "LastUpdatedDateTime", "UnitMultiplierId", "UserComponentTypeId", "Value" },
                values: new object[,]
                {
                    { 1, 27, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 26, 28, 796, DateTimeKind.Unspecified).AddTicks(6621), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 29, 4, 40, DateTimeKind.Unspecified).AddTicks(9235), 1, 1, 10f },
                    { 2, 28, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 26, 28, 810, DateTimeKind.Unspecified).AddTicks(9060), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 29, 4, 40, DateTimeKind.Unspecified).AddTicks(9396), 6, 1, 5f },
                    { 3, 29, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 26, 28, 811, DateTimeKind.Unspecified).AddTicks(2774), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 29, 4, 40, DateTimeKind.Unspecified).AddTicks(9498), 8, 1, 17f },
                    { 4, 30, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 26, 28, 811, DateTimeKind.Unspecified).AddTicks(3637), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 29, 4, 40, DateTimeKind.Unspecified).AddTicks(9595), 1, 1, 20f },
                    { 5, 31, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 26, 28, 811, DateTimeKind.Unspecified).AddTicks(4291), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 29, 4, 40, DateTimeKind.Unspecified).AddTicks(9696), 1, 1, 13f },
                    { 6, 32, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 26, 28, 811, DateTimeKind.Unspecified).AddTicks(4935), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 29, 4, 40, DateTimeKind.Unspecified).AddTicks(9788), 1, 1, 4f },
                    { 7, 33, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 26, 28, 811, DateTimeKind.Unspecified).AddTicks(5515), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 29, 4, 40, DateTimeKind.Unspecified).AddTicks(9880), 1, 1, 5f },
                    { 8, 6, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 24, 189, DateTimeKind.Unspecified).AddTicks(8378), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 36, 180, DateTimeKind.Unspecified).AddTicks(6478), 6, 2, 80f },
                    { 9, 7, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 24, 190, DateTimeKind.Unspecified).AddTicks(2853), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 36, 180, DateTimeKind.Unspecified).AddTicks(6661), 1, 2, 50f },
                    { 10, 8, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 24, 190, DateTimeKind.Unspecified).AddTicks(6350), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 36, 180, DateTimeKind.Unspecified).AddTicks(6746), 1, 2, 60f },
                    { 11, 9, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 24, 190, DateTimeKind.Unspecified).AddTicks(9247), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 36, 180, DateTimeKind.Unspecified).AddTicks(6833), 7, 2, 70f },
                    { 12, 10, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 53, 944, DateTimeKind.Unspecified).AddTicks(418), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 0, 59, DateTimeKind.Unspecified).AddTicks(81), 3, 3, 10f },
                    { 13, 11, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 53, 944, DateTimeKind.Unspecified).AddTicks(2552), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 0, 59, DateTimeKind.Unspecified).AddTicks(300), 1, 3, 0f },
                    { 14, 12, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 53, 944, DateTimeKind.Unspecified).AddTicks(3812), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 0, 59, DateTimeKind.Unspecified).AddTicks(405), 1, 3, 0f },
                    { 15, 20, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 18, 401, DateTimeKind.Unspecified).AddTicks(4599), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 26, 860, DateTimeKind.Unspecified).AddTicks(1781), 7, 4, 50f },
                    { 16, 21, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 18, 401, DateTimeKind.Unspecified).AddTicks(5681), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 26, 860, DateTimeKind.Unspecified).AddTicks(2167), 1, 4, 60f },
                    { 17, 22, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 18, 401, DateTimeKind.Unspecified).AddTicks(6136), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 26, 860, DateTimeKind.Unspecified).AddTicks(2269), 1, 4, 110f },
                    { 18, 23, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 18, 401, DateTimeKind.Unspecified).AddTicks(6559), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 26, 860, DateTimeKind.Unspecified).AddTicks(2397), 1, 4, 120f },
                    { 19, 41, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 41, 451, DateTimeKind.Unspecified).AddTicks(3311), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 50, 520, DateTimeKind.Unspecified).AddTicks(8694), 3, 5, 64f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LastUpdatedByUserId",
                table: "AspNetUsers",
                column: "LastUpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComponentTypeDetails_ComponentTypeId",
                table: "ComponentTypeDetails",
                column: "ComponentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentTypeDetails_CreatedByUserId",
                table: "ComponentTypeDetails",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentTypeDetails_LastUpdatedByUserId",
                table: "ComponentTypeDetails",
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
                name: "IX_StaticSiteInfos_CreatedByUserId",
                table: "StaticSiteInfos",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_StaticSiteInfos_LastUpdatedByUserId",
                table: "StaticSiteInfos",
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
                name: "IX_UserComponentTypeDetails_ComponentTypeDetailId",
                table: "UserComponentTypeDetails",
                column: "ComponentTypeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypeDetails_CreatedByUserId",
                table: "UserComponentTypeDetails",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypeDetails_LastUpdatedByUserId",
                table: "UserComponentTypeDetails",
                column: "LastUpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypeDetails_UnitMultiplierId",
                table: "UserComponentTypeDetails",
                column: "UnitMultiplierId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypeDetails_UserComponentTypeId",
                table: "UserComponentTypeDetails",
                column: "UserComponentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypes_ComponentTypeId",
                table: "UserComponentTypes",
                column: "ComponentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypes_CreatedByUserId",
                table: "UserComponentTypes",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComponentTypes_LastUpdatedByUserId",
                table: "UserComponentTypes",
                column: "LastUpdatedByUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "StaticSiteInfos");

            migrationBuilder.DropTable(
                name: "UserComponentTypeDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ComponentTypeDetails");

            migrationBuilder.DropTable(
                name: "UnitMultipliers");

            migrationBuilder.DropTable(
                name: "UserComponentTypes");

            migrationBuilder.DropTable(
                name: "ComponentTypes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
