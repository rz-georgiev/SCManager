using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class TempSeededData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StaticSiteInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedDateTime" },
                values: new object[] { "asdas11", new DateTime(2020, 5, 26, 7, 36, 46, 625, DateTimeKind.Utc).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "StaticSiteInfos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2020, 5, 26, 7, 36, 46, 626, DateTimeKind.Utc).AddTicks(3703));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StaticSiteInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedDateTime" },
                values: new object[] { "asdas1", new DateTime(2020, 5, 26, 7, 34, 34, 7, DateTimeKind.Utc).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "StaticSiteInfos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2020, 5, 26, 7, 34, 34, 8, DateTimeKind.Utc).AddTicks(3710));
        }
    }
}
