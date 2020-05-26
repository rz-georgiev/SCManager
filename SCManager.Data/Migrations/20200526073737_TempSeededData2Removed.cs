using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class TempSeededData2Removed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StaticSiteInfos",
                columns: new[] { "Id", "Content", "CreatedByUserId", "CreatedDateTime", "IsActive", "LastUpdatedByUserId", "LastUpdatedDateTime", "Name" },
                values: new object[] { 1, "asdas11", "538d4817-b018-4968-9a06-d0c3ac46e26b", new DateTime(2020, 5, 26, 7, 36, 46, 625, DateTimeKind.Utc).AddTicks(267), true, null, null, "asdas3" });

            migrationBuilder.InsertData(
                table: "StaticSiteInfos",
                columns: new[] { "Id", "Content", "CreatedByUserId", "CreatedDateTime", "IsActive", "LastUpdatedByUserId", "LastUpdatedDateTime", "Name" },
                values: new object[] { 2, "234v23", "538d4817-b018-4968-9a06-d0c3ac46e26b", new DateTime(2020, 5, 26, 7, 36, 46, 626, DateTimeKind.Utc).AddTicks(3703), true, null, null, "as2365bh36bhdas3" });
        }
    }
}
