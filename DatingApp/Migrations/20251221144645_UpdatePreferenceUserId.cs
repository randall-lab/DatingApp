using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePreferenceUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "256fdd03-4b25-428e-ae2f-d394e32992d9", "AQAAAAIAAYagAAAAEK5huS7YsokXnhe+Q9frhO2DfoKY6uJES31+akqRuCFWXRV9x0I7CUlXCxpi5DtFBw==", "4965895d-77b6-4231-b192-f6094b9346b1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36b20a64-1947-40bb-8420-c73246626656", "AQAAAAIAAYagAAAAEJKdy9bFNfiZHTdaQgIgTuHac5NdUtQTdQqphHO6Rh77s8BazOdOhmqd7KthlrdMwA==", "c2b3704f-dda0-4884-8653-a15e4c5d8635" });
        }
    }
}
