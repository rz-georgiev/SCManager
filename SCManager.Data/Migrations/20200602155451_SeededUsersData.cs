using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class SeededUsersData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5fb4568-51c6-43ab-8050-a5642eb9ac44", "55309049-c467-42fd-9223-e221b7c3b61a", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDateTime", "Email", "EmailConfirmed", "ImageId", "IsBanned", "LastUpdatedByUserId", "LastUpdatedDateTime", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7b26038d-1a43-4248-90e1-dc7f0381d7fa", 0, "ac202f5b-66d9-4989-a1a2-72e632a19e98", new DateTime(2020, 6, 1, 14, 57, 16, 395, DateTimeKind.Unspecified).AddTicks(9967), "scmanager_test@mail.com", true, null, false, null, null, true, null, "SCMANAGER_TEST@MAIL.COM", "SCMANAGER_TEST@MAIL.COM", "AQAAAAEAACcQAAAAEM9A4bvt/Ci2fC2r5Si1p2dEX8/v8/svgQqI1rqocSOUcWqgfzD8A8OGlpU/6qiZbQ==", null, false, "UFEWI655NFJHSNPMEJBEGWHAJKHAVWIW", false, "scmanager_test@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "7b26038d-1a43-4248-90e1-dc7f0381d7fa", "c5fb4568-51c6-43ab-8050-a5642eb9ac44" });

            migrationBuilder.InsertData(
                table: "StaticSiteInfos",
                columns: new[] { "Id", "Content", "CreatedByUserId", "CreatedDateTime", "IsActive", "LastUpdatedByUserId", "LastUpdatedDateTime", "Name" },
                values: new object[] { 5, @"&lt;h2&gt;About&lt;/h2&gt;
&lt;p&gt;SCManager is a semiconductors management application,&lt;/p&gt;
&lt;p&gt;which can also be used for a Bayesian analysis.&lt;/p&gt;
&lt;p&gt;&amp;nbsp;&lt;/p&gt;
&lt;h2&gt;Thank your for using our application!&lt;/h2&gt;
&lt;p&gt;This about info is effective as of 28 May 2020.&lt;/p&gt;", "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "About" });

            migrationBuilder.InsertData(
                table: "StaticSiteInfos",
                columns: new[] { "Id", "Content", "CreatedByUserId", "CreatedDateTime", "IsActive", "LastUpdatedByUserId", "LastUpdatedDateTime", "Name" },
                values: new object[] { 6, @"&lt;h2&gt;Privacy Policy&lt;/h2&gt;
&lt;p&gt;Your privacy is important to us. It is SCManager's policy to respect your privacy regarding any information we may collect from you across our website, &lt;a href=""http://www.scmanager.com""&gt;http://www.scmanager.com&lt;/a&gt;, and other sites we own and operate.&lt;/p&gt;
&lt;p&gt;We only ask for personal information when we truly need it to provide a service to you. We collect it by fair and lawful means, with your knowledge and consent. We also let you know why we’re collecting it and how it will be used.&lt;/p&gt;
&lt;p&gt;We only retain collected information for as long as necessary to provide you with your requested service. What data we store, we’ll protect within commercially acceptable means to prevent loss and theft, as well as unauthorized access, disclosure, copying, use or modification.&lt;/p&gt;
&lt;p&gt;We don’t share any personally identifying information publicly or with third-parties, except when required to by law.&lt;/p&gt;
&lt;p&gt;Our website may link to external sites that are not operated by us. Please be aware that we have no control over the content and practices of these sites, and cannot accept responsibility or liability for their respective privacy policies.&lt;/p&gt;
&lt;p&gt;You are free to refuse our request for your personal information, with the understanding that we may be unable to provide you with some of your desired services.&lt;/p&gt;
&lt;p&gt;Your continued use of our website will be regarded as acceptance of our practice
s around privacy and personal information. If you have any questions about how we handle user data and personal information, feel free to contact us.&lt;/p&gt;
&lt;p&gt;This policy is effective as of 28 May 2020.&lt;/p&gt;
&lt;p&gt;&lt;a href=""https://getterms.io"" title=""Generate a free privacy policy""&gt;Privacy Policy created with GetTerms.&lt;/a&gt;&lt;/p&gt;
", "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "Privacy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7b26038d-1a43-4248-90e1-dc7f0381d7fa", "c5fb4568-51c6-43ab-8050-a5642eb9ac44" });

            migrationBuilder.DeleteData(
                table: "StaticSiteInfos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StaticSiteInfos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5fb4568-51c6-43ab-8050-a5642eb9ac44");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b26038d-1a43-4248-90e1-dc7f0381d7fa");

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdatedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LastUpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_LastUpdatedByUserId",
                        column: x => x.LastUpdatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CreatedByUserId",
                table: "Posts",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_LastUpdatedByUserId",
                table: "Posts",
                column: "LastUpdatedByUserId");
        }
    }
}
