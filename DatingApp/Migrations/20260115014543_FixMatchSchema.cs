using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingApp.Migrations
{
    /// <inheritdoc />
    public partial class FixMatchSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6373c99-faf1-4c08-bb7f-63df0d1fdf59", "AQAAAAIAAYagAAAAEP4POsO1vSbcjb6y3ol9YMXtUIwWFpaaJnyDhCsbg0yV77WgdvyhfSXcIGLHwGSYxg==", "1176da1b-d71d-45c6-a7d7-d1d2c91f0c8e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0438cc9-4a76-4936-a34d-b5e98acdc68f", "AQAAAAIAAYagAAAAELPdGSFGCf3Md0QV+uR/2F1kNq3wR/JvBgWb+mqcdhPYogbWROueiOwBNLl0+EOz0Q==", "097018bf-192c-4ec9-a56c-d5eee6c2c440" });
        }
    }
}
