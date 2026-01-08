using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingApp.Migrations
{
    /// <inheritdoc />
    public partial class AddSwipeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Swipe",
                columns: table => new
                {
                    SwipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId_From = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId_To = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsLiked = table.Column<bool>(type: "bit", nullable: false),
                    SwipeDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                values: new object[] { "f1719725-928d-4419-928d-d03d4a342451", "AQAAAAIAAYagAAAAEBqevDWRlRGz1KhBTCLvbdl6H2LhDaWQvJcZXz7qoh26LxQGjbWaMIHgU3uEMJrCuQ==", "9c28daeb-8581-44d8-a384-d95cb07ebfdb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
