using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class UpdatedDataSeedingInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ComponentTypeDetails",
                columns: new[] { "Id", "ComponentTypeId", "CreatedByUserId", "CreatedDateTime", "IsActive", "IsPrimary", "LastUpdatedByUserId", "LastUpdatedDateTime", "Name", "Symbol", "Unit" },
                values: new object[,]
                {
                    { 1, 11, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 7, 40, 979, DateTimeKind.Unspecified).AddTicks(4689), true, true, null, null, "Input Voltage", "VAC", "Volt Amper" },
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
                    { 41, 9, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 21, 59, 3, DateTimeKind.Unspecified).AddTicks(2010), true, true, null, null, "Frequency", "Hz", "Hertz" },
                    { 23, 10, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 14, 59, 713, DateTimeKind.Unspecified).AddTicks(1836), true, false, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 15, 13, 370, DateTimeKind.Unspecified).AddTicks(4723), "Temperature /wave/", "℃", "Degrees" },
                    { 22, 10, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 14, 49, 111, DateTimeKind.Unspecified).AddTicks(3104), true, false, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 15, 15, 984, DateTimeKind.Unspecified).AddTicks(2547), "Operating Temperature", "℃", "Degrees" },
                    { 24, 2, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 15, 50, 318, DateTimeKind.Unspecified).AddTicks(9733), true, true, null, null, "Forward Current If /AV/", "A", "Ampers" },
                    { 20, 10, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 14, 29, 838, DateTimeKind.Unspecified).AddTicks(7786), true, true, null, null, "Voltage AC", "V", "Volts" },
                    { 2, 11, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 8, 1, 58, DateTimeKind.Unspecified).AddTicks(9372), true, false, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 8, 10, 368, DateTimeKind.Unspecified).AddTicks(8734), "Output Voltage", "V", "Volt" },
                    { 3, 11, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 8, 39, 765, DateTimeKind.Unspecified).AddTicks(4909), true, false, null, null, "Current Rating", "A", "Amper" },
                    { 4, 8, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 9, 14, 769, DateTimeKind.Unspecified).AddTicks(5434), true, true, null, null, "Resistance", "Ω", "Ohm" },
                    { 5, 8, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 9, 44, 530, DateTimeKind.Unspecified).AddTicks(3046), true, false, null, null, "Number of Channels", "C", "Count" },
                    { 6, 5, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 10, 16, 654, DateTimeKind.Unspecified).AddTicks(2810), true, true, null, null, "Resistance", "Ω", "Ohms" },
                    { 7, 5, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 10, 31, 327, DateTimeKind.Unspecified).AddTicks(3702), true, false, null, null, "Tolerance", "%", "Percents" },
                    { 21, 10, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 14, 39, 527, DateTimeKind.Unspecified).AddTicks(4307), true, false, null, null, "Current Rating", "A", "Ampers" },
                    { 9, 5, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 10, 56, 855, DateTimeKind.Unspecified).AddTicks(3270), true, false, null, null, "Voltage Rating", "V", "Volt" },
                    { 10, 13, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 11, 22, 912, DateTimeKind.Unspecified).AddTicks(8416), true, true, null, null, "Coil Voltage", "V", "Volt" },
                    { 8, 5, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 10, 45, 824, DateTimeKind.Unspecified).AddTicks(6415), true, false, null, null, "Power", "W", "Watt" },
                    { 12, 13, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 11, 49, 814, DateTimeKind.Unspecified).AddTicks(8223), true, false, null, null, "Coil Power", "W", "Watt" },
                    { 13, 7, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 12, 19, 618, DateTimeKind.Unspecified).AddTicks(2994), true, true, null, null, "Forward Current If /AV/", "A", "Ampers" },
                    { 14, 7, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 12, 28, 309, DateTimeKind.Unspecified).AddTicks(6373), true, false, null, null, "Forward Voltage Vf Max", "V", "Volt" },
                    { 15, 12, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 12, 52, 495, DateTimeKind.Unspecified).AddTicks(1972), true, true, null, null, "Max Voltage", "V", "Volts" },
                    { 16, 12, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 13, 2, 538, DateTimeKind.Unspecified).AddTicks(1600), true, false, null, null, "Max Current", "A", "Ampers" },
                    { 17, 12, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 13, 15, 894, DateTimeKind.Unspecified).AddTicks(8340), true, false, null, null, "Mounting size", "mm", "Millimeters" },
                    { 18, 3, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 13, 57, 995, DateTimeKind.Unspecified).AddTicks(4232), true, true, null, null, "Wave Length", "mm", "Millimeters" },
                    { 19, 3, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 14, 5, 311, DateTimeKind.Unspecified).AddTicks(9404), true, false, null, null, "Power", "W", "Watt" },
                    { 11, 13, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 11, 37, 726, DateTimeKind.Unspecified).AddTicks(3168), true, false, null, null, "Coil Resistance", "Ω", "Ohms" }
                });

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "LastUpdatedByUserId", "LastUpdatedDateTime", "Name" },
                values: new object[] { "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 21, 38, 798, DateTimeKind.Unspecified).AddTicks(9966), "Crystal Oscillator" });

            migrationBuilder.UpdateData(
                table: "StaticSiteInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Content", "LastUpdatedDateTime" },
                values: new object[] { @"<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);"">Name</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">SCManager</p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);"">Description</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">SCManager is a semiconductors management application, that is directed for usage by electronics and electrician specialists, so they can keep track of what components they have in stash.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color:rgba(255, 255, 255, 1);"">It can also be used in some warehouses/repair shops.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, Segoe UI, Roboto, Oxygen, Ubuntu, Cantarell, Fira Sans, Droid Sans, Helvetica Neue, Helvetica, Arial, sans-serif;"">Project github url:&nbsp;</span><a href=""https://github.com/rz-georgiev/SCManager"">https://github.com/rz-georgiev/SCManager</a></p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);"">About</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">This project will be used as a <strong>diploma work</strong> and for a <strong>CV upgrade.</strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Supervisor: Associate Professor Dr. Lyudmila Dimitrova</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1);""><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, Segoe UI, Roboto, Oxygen, Ubuntu, Cantarell, Fira Sans, Droid Sans, Helvetica Neue, Helvetica, Arial, sans-serif;"">Head of a master's program:&nbsp;</span><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px;"">Associate Professor Dr.</span><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px;"">&nbsp;Stanislav Simeonov</span></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px;"">Head of department:&nbsp;</span><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px;"">Associate Professor Dr.</span><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px;"">&nbsp;Veselina Bureva</span></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px;"">Graduate: Radoslav Georgiev</span></p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);"">Installation</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Download the project and start the solution.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Create a profile and get a private key from&nbsp;<a style=""font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;"" href=""https://sendgrid.com/"">https://sendgrid.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Create a profile and get a private key from <a style=""font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;"" href=""https://cloudinary.com/"">https://cloudinary.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Now replace these keys in your appsettings.json file.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">The application will automatically apply the migrations and the sample data seeding for you, so just build and run the solution.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, Segoe UI, Roboto, Oxygen, Ubuntu, Cantarell, Fira Sans, Droid Sans, Helvetica Neue, Helvetica, Arial, sans-serif;"">Note: First launch can be a little bit slow, because of the database creation and the data seeding.</span></p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);"">Technologies:</h3>
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
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125;"">Usage</h3>
<p><strong style=""color: rgba(74, 74, 74, 1);"">User profile:</strong></p>
<p><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">You can change your profile picture, email and password.</span></p>
<p><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">You can also download your personal data in a .json file format.</span></p>
<p><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">There is a option to delete your account and all related data to it.</span></p>
<p><span style=""color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">In the Two-factor authentication tab, you can configure an authenticator app via a QR code or a private key, so when you login, you will have an additional layer of security.</span></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); background-color: rgba(255, 255, 255, 1);""><strong>Dashboard: </strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">You can see how many components you have in total of each type and what percentage it takes from the total components count [via a progress bar].</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">In the top right of the progress bar there is a total price for all the components of the type.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">In the bottom there is a chart which shows you also the total price for each component type.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><strong>My components:</strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Here you can add a new component and fill it with Quantites, Unit price and all other properties associated with it.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubun tu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Also you can see in a nice card menu all components you have and their basic information.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><strong>Bayesian analysis TODO:</strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">###</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><strong>Admin panel:</strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Displayed in a neat fully functional tables, you can manage the Users roles,</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); background-color: rgba(255, 255, 255, 1);"">create/edit component types, create/edit unit multipliers and also edit the site Privacy and About tabs information.</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">To see and use the Admin panel you need to authorized and have the according roles [""Administrator""].</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><strong>Privacy policy:</strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">There you can read all needed information about the GDPR agreements and your user rights. [Theres is an GDPR agreement option when you first visit the website].</p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><strong>About:&nbsp;</strong></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Well, this is the page you are currently reading.</p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);"">Support</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);"">Post your questions to scmanager_test[at]mail[dot]com</p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);"">Contributing</h3>
<p><span style=""color: rgba(52, 73, 94, 1);"">Just copy the project a nd have fun</span></p>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);"">Authors and acknowledgment</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><span style=""color: rgba(52, 73, 94, 1);"">Special thanks to:</span></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a href=""https://www.microsoft.com/en-us"">https://www.microsoft.com/en-us</a></p>
<p style=""margin: 1em 0 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a href=""https://startbootstrap.com/themes/sb-admin-2/"">https://startbootstrap.com/themes/sb-admin-2/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a href=""https://github.com/StartBootstrap/startbootstrap-sb-admin-2"">https://github.com/StartBootstrap/startbootstrap-sb-admin-2</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a style=""font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;"" href=""https://sendgrid.com/"">https://sendgrid.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a style=""font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;"" href=""https://cloudinary.com/"">https://cloudinary.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxyg en, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a href=""https://github.com/mganss/HtmlSanitizer"">https://github.com/mganss/HtmlSanitizer</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1);""><a href=""https://www.chartjs.org/"">https://www.chartjs.org/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a href=""https://datatables.net/"">https://datatables.net/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a href=""https://fontawesome.com/"">https://fontawesome.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a href=""https://www.tiny.cloud/"">https://www.tiny.cloud/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><a href=""https://jquery.com/"">https://jquery.com/</a></p>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); background-color: rgba(255, 255, 255, 1);""><a href=""https://getbootstrap.com/"">https://getbootstrap.com/</a></p>
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

THE SOFTWARE IS PROVIDED ""AS IS"",WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHE
R IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.</pre>
<h3 style=""margin: 1em 0 1.5rem; padding: 0; font-size: 1.5rem; color: rgba(54, 54, 54, 1); line-height: 1.125; font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; background-color: rgba(255, 255, 255, 1);"">Project status</h3>
<p style=""margin: 1em 0 0; padding: 0; color: rgba(74, 74, 74, 1); font-family: BlinkMacSystemFont, -apple-system, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; background-color: rgba(255, 255, 255, 1);""><span style=""color: rgba(52, 73, 94, 1);"">Currently in development.</span></p>", new DateTime(2020, 6, 19, 19, 33, 13, 892, DateTimeKind.Unspecified).AddTicks(3650) });

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
                    { 17, 22, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 18, 401, DateTimeKind.Unspecified).AddTicks(6136), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 26, 860, DateTimeKind.Unspecified).AddTicks(2269), 1, 4, 110f },
                    { 16, 21, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 18, 401, DateTimeKind.Unspecified).AddTicks(5681), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 26, 860, DateTimeKind.Unspecified).AddTicks(2167), 1, 4, 60f },
                    { 15, 20, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 18, 401, DateTimeKind.Unspecified).AddTicks(4599), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 26, 860, DateTimeKind.Unspecified).AddTicks(1781), 7, 4, 50f },
                    { 14, 12, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 53, 944, DateTimeKind.Unspecified).AddTicks(3812), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 0, 59, DateTimeKind.Unspecified).AddTicks(405), 1, 3, 0f },
                    { 13, 11, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 53, 944, DateTimeKind.Unspecified).AddTicks(2552), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 0, 59, DateTimeKind.Unspecified).AddTicks(300), 1, 3, 0f },
                    { 12, 10, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 53, 944, DateTimeKind.Unspecified).AddTicks(418), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 0, 59, DateTimeKind.Unspecified).AddTicks(81), 3, 3, 10f },
                    { 11, 9, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 24, 190, DateTimeKind.Unspecified).AddTicks(9247), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 36, 180, DateTimeKind.Unspecified).AddTicks(6833), 7, 2, 70f },
                    { 18, 23, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 18, 401, DateTimeKind.Unspecified).AddTicks(6559), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 26, 860, DateTimeKind.Unspecified).AddTicks(2397), 1, 4, 120f },
                    { 10, 8, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 24, 190, DateTimeKind.Unspecified).AddTicks(6350), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 36, 180, DateTimeKind.Unspecified).AddTicks(6746), 1, 2, 60f },
                    { 8, 6, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 24, 189, DateTimeKind.Unspecified).AddTicks(8378), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 36, 180, DateTimeKind.Unspecified).AddTicks(6478), 6, 2, 80f },
                    { 7, 33, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 26, 28, 811, DateTimeKind.Unspecified).AddTicks(5515), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 29, 4, 40, DateTimeKind.Unspecified).AddTicks(9880), 1, 1, 5f },
                    { 6, 32, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 26, 28, 811, DateTimeKind.Unspecified).AddTicks(4935), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 29, 4, 40, DateTimeKind.Unspecified).AddTicks(9788), 1, 1, 4f },
                    { 5, 31, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 26, 28, 811, DateTimeKind.Unspecified).AddTicks(4291), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 29, 4, 40, DateTimeKind.Unspecified).AddTicks(9696), 1, 1, 13f },
                    { 4, 30, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 26, 28, 811, DateTimeKind.Unspecified).AddTicks(3637), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 29, 4, 40, DateTimeKind.Unspecified).AddTicks(9595), 1, 1, 20f },
                    { 3, 29, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 26, 28, 811, DateTimeKind.Unspecified).AddTicks(2774), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 29, 4, 40, DateTimeKind.Unspecified).AddTicks(9498), 8, 1, 17f },
                    { 2, 28, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 26, 28, 810, DateTimeKind.Unspecified).AddTicks(9060), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 29, 4, 40, DateTimeKind.Unspecified).AddTicks(9396), 6, 1, 5f },
                    { 9, 7, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 24, 190, DateTimeKind.Unspecified).AddTicks(2853), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 27, 36, 180, DateTimeKind.Unspecified).AddTicks(6661), 1, 2, 50f },
                    { 19, 41, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 41, 451, DateTimeKind.Unspecified).AddTicks(3311), true, "7b26038d-1a43-4248-90e1-dc7f0381d7fa", new DateTime(2020, 6, 19, 19, 28, 50, 520, DateTimeKind.Unspecified).AddTicks(8694), 3, 5, 64f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "UserComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UserComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UserComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UserComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UserComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UserComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ComponentTypeDetails",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "UserComponentTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserComponentTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserComponentTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserComponentTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserComponentTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "LastUpdatedByUserId", "LastUpdatedDateTime", "Name" },
                values: new object[] { null, null, null });

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
        }
    }
}
