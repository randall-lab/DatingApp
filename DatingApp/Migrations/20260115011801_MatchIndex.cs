using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingApp.Migrations
{
    /// <inheritdoc />
    public partial class MatchIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0438cc9-4a76-4936-a34d-b5e98acdc68f", "AQAAAAIAAYagAAAAELPdGSFGCf3Md0QV+uR/2F1kNq3wR/JvBgWb+mqcdhPYogbWROueiOwBNLl0+EOz0Q==", "097018bf-192c-4ec9-a56c-d5eee6c2c440" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09443e1c-9974-42c3-a33f-f67e83542ff8", "AQAAAAIAAYagAAAAECNR1Qxp0Pqj10Chj7WEbMkb1fF+KV9EX1gojfmf9mNlexNJ19Koas7QpVR4OKLw9g==", "08ca2967-e7d9-41d5-99c7-1a9c6e267d1a" });
        }
    }
}
