using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class SeededDataThroughResxFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3aab7018-2979-4572-b055-4669e941539e", 0, "0362063e-dd67-4a62-8373-3571d9c57a8e", "scmanager_test@mail.com", true, null, true, null, "SCMANAGER_TEST@MAIL.COM", "SCMANAGER_TEST@MAIL.COM", "AQAAAAEAACcQAAAAENVTuxD0CHO58asb1YYHB7BCfrbb28i8QbuIWy0eGcGaqcAk7eZ7l2vhxxFAC588IQ==", null, false, "ROXYKWZHZ7G3OCTW6353NH34QHXJ2JMF", false, "scmanager_test@mail.com" });

            migrationBuilder.InsertData(
                table: "StaticSiteInfos",
                columns: new[] { "Id", "Content", "CreatedByUserId", "CreatedDateTime", "IsActive", "LastUpdatedByUserId", "LastUpdatedDateTime", "Name" },
                values: new object[] { 5, @"<h2>About</h2>
<p>SCManager is a semiconductors management application,</p>
<p>which can also be used for a Bayesian analysis.</p>
<p>&nbsp;</p>
<h2>Thank your for using our application!</h2>
<p>This about info is effective as of 28 May 2020.</p>", "3aab7018-2979-4572-b055-4669e941539e", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "About" });

            migrationBuilder.InsertData(
                table: "StaticSiteInfos",
                columns: new[] { "Id", "Content", "CreatedByUserId", "CreatedDateTime", "IsActive", "LastUpdatedByUserId", "LastUpdatedDateTime", "Name" },
                values: new object[] { 6, @"<h2>Privacy Policy</h2>
<p>Your privacy is important to us. It is SCManager's policy to respect your privacy regarding any information we may collect from you across our website, <a href=""http://www.scmanager.com"">http://www.scmanager.com</a>, and other sites we own and operate.</p>
<p>We only ask for personal information when we truly need it to provide a service to you. We collect it by fair and lawful means, with your knowledge and consent. We also let you know why we’re collecting it and how it will be used.</p>
<p>We only retain collected information for as long as necessary to provide you with your requested service. What data we store, we’ll protect within commercially acceptable means to prevent loss and theft, as well as unauthorized access, disclosure, copying, use or modification.</p>
<p>We don’t share any personally identifying information publicly or with third-parties, except when required to by law.</p>
<p>Our website may link to external sites that are not operated by us. Please be aware that we have no control over the content and practices of these sites, and cannot accept responsibility or liability for their respective privacy policies.</p>
<p>You are free to refuse our request for your personal information, with the understanding that we may be unable to provide you with some of your desired services.</p>
<p>Your continued use of our website will be regarded as acceptance of our practice
s around privacy and personal information. If you have any questions about how we handle user data and personal information, feel free to contact us.</p>
<p>This policy is effective as of 28 May 2020.</p>
<p><a href=""https://getterms.io"" title=""Generate a free privacy policy"">Privacy Policy created with GetTerms.</a></p>
", "3aab7018-2979-4572-b055-4669e941539e", new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, "Privacy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StaticSiteInfos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StaticSiteInfos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3aab7018-2979-4572-b055-4669e941539e");
        }
    }
}
