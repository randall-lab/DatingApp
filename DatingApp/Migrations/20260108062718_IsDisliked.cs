using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingApp.Migrations
{
    /// <inheritdoc />
    public partial class IsDisliked : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDislike",
                table: "Swipe",
                newName: "IsDisliked");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03cf6842-ff0c-4cf5-95ad-a50eb90f48ad", "AQAAAAIAAYagAAAAEJe9D05RVC0NBzrYp/M1tm4htq37P0vqGUSnVErrhwbqfId1iQDXMPwWxiVUAZZOyA==", "93afecb1-be11-4998-954e-37d1cea95418" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDisliked",
                table: "Swipe",
                newName: "IsDislike");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf042cc2-83af-44d2-a99e-32e1f3d694c7", "AQAAAAIAAYagAAAAEOYnqAn5haXK3OXqL+otur4ngKBGt33JBC5HWIfho6SaY6P7pVc93P/DsYweM1AJGQ==", "28a5a753-923d-4624-81eb-c12bb65c3235" });
        }
    }
}
