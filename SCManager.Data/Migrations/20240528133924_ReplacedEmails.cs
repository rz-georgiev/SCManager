using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReplacedEmails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b26038d-1a43-4248-90e1-dc7f0381d7fa",
                columns: new[] { "Email", "UserName" },
                values: new object[] { "postmaster@scmanager.space", "postmaster@scmanager.space" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b26038d-1a43-4248-90e1-dc7f0381d7fa",
                columns: new[] { "Email", "UserName" },
                values: new object[] { "scmanager_test@mail.com", "scmanager_test@mail.com" });
        }
    }
}
