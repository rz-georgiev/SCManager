using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class SeedingNewDefaultDataPart1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37152c28-98e0-4067-93eb-f708a463d91b", "514f4df7-f0a4-4b34-aaf8-54c4c874f824", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b26038d-1a43-4248-90e1-dc7f0381d7fa",
                column: "ConcurrencyStamp",
                value: "53ea6bca-6c80-400c-9cb5-ac31d508a7f7");

            migrationBuilder.InsertData(
                table: "ComponentTypes",
                columns: new[] { "Id", "CreatedByUserId", "CreatedDateTime", "ImageId", "IsActive", "LastUpdatedByUserId", "LastUpdatedDateTime", "Name" },
                values: new object[,]
                {
                    { 2, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 12, 19, 20, 856, DateTimeKind.Unspecified).AddTicks(471), "efhvoagzh1gnmkexv0y8", true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 12, 24, 20, 943, DateTimeKind.Unspecified).AddTicks(7730), "Diode" },
                    { 1, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 12, 4, 56, 317, DateTimeKind.Unspecified).AddTicks(8451), "rvujbwa21jy4nqzpv6nh", true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 12, 12, 0, 471, DateTimeKind.Unspecified).AddTicks(893), "DIAC" },
                    { 11, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 14, 57, 27, 786, DateTimeKind.Unspecified).AddTicks(5864), "losd0lliduyy1fhqoojg", true, null, null, "Transformer ANG" },
                    { 10, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 14, 54, 13, 960, DateTimeKind.Unspecified).AddTicks(1813), "b5ahc0huvnrut6tdu8vk", true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 14, 54, 44, 294, DateTimeKind.Unspecified).AddTicks(6969), "Glass Fuse" },
                    { 9, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 14, 43, 25, 949, DateTimeKind.Unspecified).AddTicks(4934), "aogdmckdrbky4gbhomvu", true, null, null, null },
                    { 8, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 14, 41, 41, 536, DateTimeKind.Unspecified).AddTicks(9498), "qnmrcwmy5olwjlypeexo", true, null, null, "Rotary Potentiometer" },
                    { 13, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 14, 59, 54, 289, DateTimeKind.Unspecified).AddTicks(3478), "yz9fugamyiequafspij9", true, null, null, "Relay" },
                    { 6, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 14, 16, 31, 944, DateTimeKind.Unspecified).AddTicks(2860), "bgwxgy88kkmfvuqdtdfk", true, null, null, " Multilayer Ceramic Capacitor" },
                    { 5, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 14, 15, 2, 6, DateTimeKind.Unspecified).AddTicks(5389), "vcashzbdmgd8noof9zzl", true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 14, 40, 56, 894, DateTimeKind.Unspecified).AddTicks(5722), "Resistor Carbon Film" },
                    { 4, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 13, 18, 36, 643, DateTimeKind.Unspecified).AddTicks(5948), "umsim0anwiykqdhpj7ck", true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 13, 23, 28, 154, DateTimeKind.Unspecified).AddTicks(105), "Bipolar transistor" },
                    { 3, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 12, 24, 55, 905, DateTimeKind.Unspecified).AddTicks(2576), "eudwin9a4ay1esc1xx9l", true, null, null, "Laser diode" },
                    { 7, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 14, 39, 51, 852, DateTimeKind.Unspecified).AddTicks(3589), "jj7pylgna5ux2rncs0ma", true, null, null, "Rectifier Bridge" },
                    { 12, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 18, 14, 58, 42, 336, DateTimeKind.Unspecified).AddTicks(253), "i7o99nbw9zqncou3w8rw", true, null, null, "Push Button Switch" }
                });

            migrationBuilder.UpdateData(
                table: "StaticSiteInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Content", "LastUpdatedDateTime" },
                values: new object[] { @"<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);"">Name</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">SCManager</p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);"">Description</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">SCManager is a semiconductors management application, that is directed for usage by electronics and electrician specialists, so they can keep track of what components they have in stash.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color:
 rgba(255, 255, 255, 1);"">It can also be used in some warehouses/repair shops.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, Segoe UI, Roboto, Oxygen, Ubuntu, Cantarell, Fira Sans, Droid Sans, Helvetica Neue, Helvetica, Arial, sans-serif;"">Project github url:&nbsp;</span><a href=""https://github.com/rz-georgiev/SCManager"">https://github.com/rz-georgiev/SCManager</a></p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);"">About</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">This project will be used as a <strong>diploma work</strong> and for a <strong>CV upgrade.</strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Supervisor: Associate Professor Dr. Lyudmila Dimitrova</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'D
roid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, Segoe UI, Roboto, Oxygen, Ubuntu, Cantarell, Fira Sans, Droid Sans, Helvetica Neue, Helvetica, Arial, sans-serif;"">Head of a master's program:&nbsp;</span><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px;"">Associate Professor Dr.</span><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px;"">&nbsp;Stanislav Simeonov</span></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px;"">Head of department:&nbsp;</span><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px;"">Associate Professor Dr.</span><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px;"">&nbsp;Veselina Bureva</span></p>
<p style=""margin: 1em 0 0; padding: 
0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px;"">Graduate: Radoslav Georgiev</span></p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);"">Installation</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Download the project and start the solution.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Create a profile and get a private key from&nbsp;<a style=""font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;"" href=""https://sendgrid.com/"">https://sendgrid.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial
, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Create a profile and get a private key from <a style=""font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;"" href=""https://cloudinary.com/"">https://cloudinary.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Now replace these keys in your appsettings.json file.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">The application will automatically apply the migrations and the sample data seeding for you, so just build and run the solution.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, Segoe UI, Roboto, Oxygen, Ubuntu, Cantarell, Fira Sans, Droid Sans, Helvetica Neue, Helvetica, Arial, sans-serif;"">Note: First launch can be a little bit slow, because of the database creation and the data seeding.</span></p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial
, sans-serif; background-color: rgba(255, 255, 255, 1);"">Technologies:</h3>
<p><span style=""color: rgba(52, 73, 94, 1);"">* .NET Core 3.1</span></p>
<p><span style=""color: rgba(52, 73, 94, 1);"">* Entity Framework Core</span></p>
<p><span style=""color: rgba(52, 73, 94, 1);"">* AutoMapper</span></p>
<p><span style=""color: rgba(52, 73, 94, 1);"">* BuildBundlerMinifier</span></p>
<p><span style=""color: rgba(52, 73, 94, 1);"">* Cloudinary.Core</span></p>
<p><span style=""color: rgba(52, 73, 94, 1);"">* HtmlSanitizer</span></p>
<p><span style=""color: rgba(52, 73, 94, 1);"">* Bootstrap</span></p>
<p><span style=""color: rgba(52, 73, 94, 1);"">* SendGrid</span></p>
<p><span style=""color: rgba(52, 73, 94, 1);"">* Chart.js</span></p>
<p><span style=""color: rgba(52, 73, 94, 1);"">* Datatables.js</span></p>
<p><span style=""color: rgba(52, 73, 94, 1);"">* JQuery</span></p>
<p><span style=""color: rgba(52, 73, 94, 1);"">* ML.NET for the Bayesian analysis</span></p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);"">Features</h3>
<p><span style=""color: rgba(52, 73, 94, 1);"">* Enabled ASP.NET Core Identity authentication [extended via ApplicationUser class]</span></p>
<p><span style=""color: rgba(52, 73, 94, 1);"">* Enabled auto-generation of antiforgery token for each post request.</span></p>
<p><span style=""color: rgba(52, 73, 94, 1);"">* Enabled by default - protection from XSS attacks via the HTML Razor symbol escape operations</span></p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, '
Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);"">Usage</h3>
<p><strong style=""color: rgba(74, 74, 74, 1);"">User profile:</strong></p>
<p><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">You can change your profile picture, email and password.</span></p>
<p><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">You can also download your personal data in a .json file format.</span></p>
<p><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">There is a option to delete your account and all related data to it.</span></p>
<p><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">In the Two-factor authentication tab, you can configure an authenticator app via a QR code or a private key, so when you login, you will have an additional layer of security.</span></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); background-color: rgba(255, 255, 255, 1);""><strong>Dashboard: </strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto,
 Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">You can see how many components you have in total of each type and what percentage it takes from the total components count [via a progress bar].</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">In the top right of the progress bar there is a total price for all the components of the type.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">In the bottom there is a chart which shows you also the total price for each component type.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><strong>My components:</strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Here you can add a new component and fill it with Quantites, Unit price and all other properties associated with it.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubun
tu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Also you can see in a nice card menu all components you have and their basic information.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><strong>Bayesian analysis TODO:</strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">###</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><strong>Admin panel:</strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Displayed in a neat fully functional tables, you can manage the Users roles,</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); background-color: rgba(255, 255, 255, 1);"">create/edit component types, create/edit unit multipliers and also edit the site Privacy and About tabs information.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 
'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">To see and use the Admin panel you need to authorized and have the according roles [""Administrator""].</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><strong>Privacy policy:</strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">There you can read all needed information about the GDPR agreements and your user rights. [Theres is an GDPR agreement option when you first visit the website].</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><strong>About:&nbsp;</strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Well, this is the page you are currently reading.</p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif
; background-color: rgba(255, 255, 255, 1);"">Support</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Post your questions to scmanager_test@mail.com</p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);"">Contributing</h3>
<p><span style=""color: rgba(52, 73, 94, 1);"">Just copy the project a nd have fun</span></p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);"">Authors and acknowledgment</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><span style=""color: rgba(52, 73, 94, 1);"">Special thanks to:</span></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a href=""https://www.microsoft.com/en-us"">https://www.microsoft.com/en-us</a></p>
<p style=""margin: 1em 0 0; paddi
ng: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a href=""https://startbootstrap.com/themes/sb-admin-2/"">https://startbootstrap.com/themes/sb-admin-2/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a href=""https://github.com/StartBootstrap/startbootstrap-sb-admin-2"">https://github.com/StartBootstrap/startbootstrap-sb-admin-2</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a style=""font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;"" href=""https://sendgrid.com/"">https://sendgrid.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a style=""font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;"" href=""https://cloudinary.com/"">https://cloudinary.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxyg
en, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a href=""https://github.com/mganss/HtmlSanitizer"">https://github.com/mganss/HtmlSanitizer</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1);""><a href=""https://www.chartjs.org/"">https://www.chartjs.org/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a href=""https://datatables.net/"">https://datatables.net/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a href=""https://fontawesome.com/"">https://fontawesome.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a href=""https://www.tiny.cloud/"">https://www.tiny.cloud/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a href=""https://jquery.com/"">https://jquery.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); background-color: rgba(255, 255, 255
, 1);""><a href=""https://getbootstrap.com/"">https://getbootstrap.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); background-color: rgba(255, 255, 255, 1);""><a href=""https://www.freepik.com/free-photos-vectors/web-banner"">https://www.freepik.com/free-photos-vectors/web-banner</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); background-color: rgba(255, 255, 255, 1);""><a href=""https://undraw.co/illustrations"">https://undraw.co/illustrations</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Me: R. Georgiev</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">&nbsp;</p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);"">License</h3>
<pre style=""overflow: auto; font-family: Consolas, Monaco, Courier, monospace; font-size: 14px; background-color: rgba(255, 255, 255, 1); border: 1px solid rgba(238, 238, 238, 1); border-radius: 3px; padding: 20px; color: rgba(92, 88, 85, 1);"">MIT License

Copyright (c) [2020] [SCManager]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the ""Software""), to deal
in the Software without restric
tion, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so
, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHE
R IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.</pre>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);"">Project status</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><span style=""color: rgba(52, 73, 94, 1);"">Currently in development.</span></p>", new DateTime(2020, 6, 19, 14, 56, 30, 141, DateTimeKind.Unspecified).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "StaticSiteInfos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Content",
                value: @"<p>Your privacy is important to us. It is SCManager's policy to respect your privacy regarding any information we may collect from you across our website, <a href=""http://www.scmanager.com/"">http://www.scmanager.com/</a>, and other sites we
 own and operate.</p>
<p>We only ask for personal information when we truly need it to provide a service to you. We collect it by fair and lawful means, with your knowledge and consent. We also let you know why we&rsquo;re collecting it and how it will be used.</p>
<p>We only retain collected information for as long as necessary to provide you with your requested service. What data we store, we&rsquo;ll protect within commercially acceptable means to prevent loss and theft, as well as unauthorized access, disclosure, copying, use or modification.</p>
<p>We don&rsquo;t share any personally identifying information publicly or with third-parties, ex
cept when required to by law.</p>
<p>Our website may link to external sites that are not operated by us. Please be aware that we have no control over the content and practices of these sites, and cannot accept responsibility or liability for their respective privacy policies.</p>
<p>You are free to refuse our request for your personal information, with the understanding that we may be unable to provide you with some of your desired services.</p>
<p>Your continued use of our website will be regarded as acceptance of our practices around privacy and persona
l information. If you have any questions about how we handle user data and personal information, feel free to contact us.</p>
<p>&nbsp;</p>
<p>This policy is effective as of 2 June 2020.</p>
<p>&nbsp;</p>
<p>Best regards,</p>
<p>The SCManager team</p>
<p>&nbsp;</p>
<p><a title=""Generate a free privacy policy"" href=""https://getterms.io"">Privacy Policy created with GetTerms.</a></p>");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37152c28-98e0-4067-93eb-f708a463d91b");

            migrationBuilder.DeleteData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UnitMultipliers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UnitMultipliers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UnitMultipliers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UnitMultipliers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UnitMultipliers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UnitMultipliers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UnitMultipliers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UnitMultipliers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b26038d-1a43-4248-90e1-dc7f0381d7fa",
                column: "ConcurrencyStamp",
                value: "ac202f5b-66d9-4989-a1a2-72e632a19e98");

            migrationBuilder.UpdateData(
                table: "StaticSiteInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Content", "LastUpdatedDateTime" },
                values: new object[] { @"<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1)"">Name</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">SCManager</p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1)"">Description</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">SCManager is a semiconductors management application, that is directed for usage by electronics and electrician specialists, so they can keep track of what components they have in stash.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Se
goe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">It can also be used in some warehouses/repair shops.</p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1)"">About</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">This project will be used as a <strong>diploma work</strong> and for a <strong>CV upgrade.</strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">Supervisor: Associate Professor Dr. Lyudmila Dimitrova</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, Segoe UI, Roboto, Oxygen, Ubuntu, Cantarell, Fira Sans, Droid Sans, Helvetica Neue, Helvetica, Arial, sans-
serif"">Head of a master's program:&nbsp;</span><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px"">Associate Professor Dr.</span><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px"">&nbsp;Stanislav Simeonov</span></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px"">Head of department:&nbsp;</span><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px"">Associate Professor Dr.</span><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px"">&nbsp;Veselina Bureva</span></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Sego
e UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px"">Graduate: Radoslav Georgiev</span></p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1)"">Installation</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">Download the project and start the solution.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">Create a profile and get a private key from&nbsp;<a style=""font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Open Sans&quot;, &quot;Helvetica Neue&quot;, sans-serif"" href=""https://sendgrid.com/"">https://sendgrid.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFo
nt, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">Create a profile and get a private key from <a style=""font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Open Sans&quot;, &quot;Helvetica Neue&quot;, sans-serif"" href=""https://cloudinary.com/"">https://cloudinary.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">Now replace these keys in your appsettings.json file.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">The application will automatically apply the migrations and the sample data seeding for you, so just build and run the solution.</p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1)"">Technologies:</h3>
<p><span style=""color: rgba(52, 73, 94, 1)"">* .NET Core 3.1</span></p>
<p><span style=""color: rgba(52, 73, 94, 1)"">* Entity Framework Core</span></p>
<p><span style=""color: rgba(52, 73, 94, 1)"">* AutoMapper</span></p>
<p>
<span style=""color: rgba(52, 73, 94, 1)"">* BuildBundlerMinifier</span></p>
<p><span style=""color: rgba(52, 73, 94, 1)"">* Cloudinary.Core</span></p>
<p><span style=""color: rgba(52, 73, 94, 1)"">* HtmlSanitizer</span></p>
<p><span style=""color: rgba(52, 73, 94, 1)"">* Bootstrap</span></p>
<p><span style=""color: rgba(52, 73, 94, 1)"">* SendGrid</span></p>
<p><span style=""color: rgba(52, 73, 94, 1)"">* Chart.js</span></p>
<p><span style=""color: rgba(52, 73, 94, 1)"">* Datatables.js</span></p>
<p><span style=""color: rgba(52, 73, 94, 1)"">* JQuery</span></p>
<p><span style=""color: rgba(52, 73, 94, 1)"">* ML.NET for the Bayesian analysis</span></p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1)"">Features</h3>
<p><span style=""color: rgba(52, 73, 94, 1)"">* Enabled ASP.NET Core Identity authentication [extended via ApplicationUser class]</span></p>
<p><span style=""color: rgba(52, 73, 94, 1)"">* Enabled auto-generation of antiforgery token for each post request.</span></p>
<p><span style=""color: rgba(52, 73, 94, 1)"">* Enabled by default - protection from XSS attacks via the HTML Razor symbol escape operations</span></p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1)"">Usage</h3>
<p><strong style=""color: rgba(74, 74, 74, 1)"">User profile:</strong></p>
<p><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont,
 -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">You can change your profile picture, email and password.</span></p>
<p><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">You can also download your personal data in a .json file format.</span></p>
<p><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">There is a option to delete your account and all related data to it.</span></p>
<p><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">In the Two-factor authentication tab, you can configure an authenticator app via a QR code or a private key, so when you login, you will have an additional layer of security.</span></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); background-color: rgba(255, 255, 255, 1)""><strong>Dashboard: </strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; fon
t-size: 16px; background-color: rgba(255, 255, 255, 1)"">You can see how many components you have in total of each type and what percentage it takes from the total components count [via a progress bar].</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">In the top right of the progress bar there is a total price for all the components of the type.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">In the bottom there is a chart which shows you also the total price for each component type.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><strong>My components:</strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">Here you can add a new component and fill it with Quantites, Unit price and all other properties associated with it.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-s
ystem, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">Also you can see in a nice card menu all components you have and their basic information.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><strong>Bayesian analysis TODO:</strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">###</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><strong>Admin panel:</strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">Displayed in a neat fully functional tables, you can manage the Users roles,</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot
;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">create/edit component types, create/edit unit multipliers and also edit the site Privacy and About tabs information.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">To see and use the Admin panel you need to authorized and have the according roles [""Administrator""].</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><strong>Privacy policy:</strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">There you can read all needed information about the GDPR agreements and your user rights. [Theres is an GDPR agreement option when you first visit the website].</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><strong>About:&nbsp;</strong></p>
<p style=""margin: 1em 0 0; padding: 0; co
lor: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">Well, this is the page you are currently reading.</p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1)"">Support</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">Post your questions to scmanager_test@mail.com</p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1)"">Contributing</h3>
<p><span style=""color: rgba(52, 73, 94, 1)"">Just copy the project a nd have fun</span></p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1)"">Authors and acknowledgment</h3>
<p style=""margin: 1em 0 0;
 padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><span style=""color: rgba(52, 73, 94, 1)"">Special thanks to:</span></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><a href=""https://www.microsoft.com/en-us"">https://www.microsoft.com/en-us</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><a href=""https://startbootstrap.com/themes/sb-admin-2/"">https://startbootstrap.com/themes/sb-admin-2/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><a href=""https://github.com/StartBootstrap/startbootstrap-sb-admin-2"">https://github.com/StartBootstrap/startbootstrap-sb-admin-2</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Aria
l, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><a style=""font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Open Sans&quot;, &quot;Helvetica Neue&quot;, sans-serif"" href=""https://sendgrid.com/"">https://sendgrid.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><a style=""font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Open Sans&quot;, &quot;Helvetica Neue&quot;, sans-serif"" href=""https://cloudinary.com/"">https://cloudinary.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><a href=""https://github.com/mganss/HtmlSanitizer"">https://github.com/mganss/HtmlSanitizer</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1)""><a href=""https://www.chartjs.org/"">https://www.chartjs.org/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><a href=""https://datatables.net/"">https://datatables.net/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -ap
ple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><a href=""https://fontawesome.com/"">https://fontawesome.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><a href=""https://www.tiny.cloud/"">https://www.tiny.cloud/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><a href=""https://jquery.com/"">https://jquery.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); background-color: rgba(255, 255, 255, 1)""><a href=""https://getbootstrap.com/"">https://getbootstrap.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); background-color: rgba(255, 255, 255, 1)""><a href=""https://www.freepik.com/free-photos-vectors/web-banner"">https://www.freepik.com/free-photos-vectors/web-banner</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); background-color: rgba(255, 255, 255, 1)""><a href=""https://undraw.co/illustrations"">https://undraw.co/illustrations</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, He
lvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">Me: R. Georgiev</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)"">&nbsp;</p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1)"">License</h3>
<pre style=""overflow: auto; font-family: Consolas, Monaco, Courier, monospace; font-size: 14px; background-color: rgba(255, 255, 255, 1); border: 1px solid rgba(238, 238, 238, 1); border-radius: 3px; padding: 20px; color: rgba(92, 88, 85, 1)"">MIT License

Copyright (c) [2020] [SCManager]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the ""Software""), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so
, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHE
R IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.</pre>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1)"">Project status</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, &quot;Segoe UI&quot;, Roboto, Oxygen, Ubuntu, Cantarell, &quot;Fira Sans&quot;, &quot;Droid Sans&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1)""><span style=""color: rgba(52, 73, 94, 1)"">Currently in development.</span></p>", new DateTime(2020, 6, 18, 10, 50, 49, 654, DateTimeKind.Unspecified).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "StaticSiteInfos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Content",
                value: @"<p>Your privacy is important to us. It is SCManager's policy to respect your privacy regarding any information we may collect from you across our website, <a href=""http://www.scmanager.com/"">http://www.scmanager.com/</a>, and other sites we own and operate.</p>
<p>We only ask for personal information when we truly need it to provide a service to you. We collect it by fair and lawful means, with your knowledge and consent. We also let you know why we&rsquo;re collecting it and how it will be used.</p>
<p>We only retain collected information for as long as necessary to provide you with your requested service. What data we store, we&rsquo;ll protect within commercially acceptable means to prevent loss and theft, as well as unauthorized access, disclosure, copying, use or modification.</p>
<p>We don&rsquo;t share any personally identifying information publicly or with third-parties, ex
cept when required to by law.</p>
<p>Our website may link to external sites that are not operated by us. Please be aware that we have no control over the content and practices of these sites, and cannot accept responsibility or liability for their respective privacy policies.</p>
<p>You are free to refuse our request for your personal information, with the understanding that we may be unable to provide you with some of your desired services.</p>
<p>Your continued use of our website will be regarded as acceptance of our practices around privacy and persona
l information. If you have any questions about how we handle user data and personal information, feel free to contact us.</p>
<p>&nbsp;</p>
<p>This policy is effective as of 2 June 2020.</p>
<p>&nbsp;</p>
<p>Best regards,</p>
<p>The SCManager team</p>
<p>&nbsp;</p>
<p><a title=""Generate a free privacy policy"" href=""https://getterms.io"">Privacy Policy created with GetTerms.</a></p>");
        }
    }
}
