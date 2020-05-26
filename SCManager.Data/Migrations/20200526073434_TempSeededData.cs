using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class TempSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StaticSiteInfos",
                columns: new[] { "Id", "Content", "CreatedByUserId", "CreatedDateTime", "IsActive", "LastUpdatedByUserId", "LastUpdatedDateTime", "Name" },
                values: new object[] { 1, "asdas1", "538d4817-b018-4968-9a06-d0c3ac46e26b", new DateTime(2020, 5, 26, 7, 34, 34, 7, DateTimeKind.Utc).AddTicks(64), true, null, null, "asdas3" });

            migrationBuilder.InsertData(
                table: "StaticSiteInfos",
                columns: new[] { "Id", "Content", "CreatedByUserId", "CreatedDateTime", "IsActive", "LastUpdatedByUserId", "LastUpdatedDateTime", "Name" },
                values: new object[] { 2, "234v23", "538d4817-b018-4968-9a06-d0c3ac46e26b", new DateTime(2020, 5, 26, 7, 34, 34, 8, DateTimeKind.Utc).AddTicks(3710), true, null, null, "as2365bh36bhdas3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StaticSiteInfos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StaticSiteInfos",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
