using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingApp.Migrations
{
    /// <inheritdoc />
    public partial class AddIsLikedAndSwipeDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Swipe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cf08762-7019-4474-b013-0d3c08888ab9", "AQAAAAIAAYagAAAAEBuvgIVxcpbjlm0uyOK8HGNmqULCNUu7X41jFDZj6bi93VDdFsF5qkM+fC83E/rauQ==", "763156a3-0376-45cd-adca-631def66ec1b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Swipe",
                columns: table => new
                {
                    SwipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId_From = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId_To = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Swipe", x => x.SwipeId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "256fdd03-4b25-428e-ae2f-d394e32992d9", "AQAAAAIAAYagAAAAEK5huS7YsokXnhe+Q9frhO2DfoKY6uJES31+akqRuCFWXRV9x0I7CUlXCxpi5DtFBw==", "4965895d-77b6-4231-b192-f6094b9346b1" });
        }
    }
}
