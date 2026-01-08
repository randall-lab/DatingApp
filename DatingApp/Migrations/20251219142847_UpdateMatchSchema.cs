using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMatchSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchParticipant");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Profile",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "Message",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MatchedBy",
                table: "Match",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatchedOnCriteria",
                table: "Match",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId_One",
                table: "Match",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId_Two",
                table: "Match",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "MatchCriteria",
                columns: table => new
                {
                    MatchCriteriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchId = table.Column<int>(type: "int", nullable: false),
                    PreferenceId = table.Column<int>(type: "int", nullable: false),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    CriteriaType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CriteriaValue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchCriteria", x => x.MatchCriteriaId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03fcb38b-690e-4b7d-944c-0ebbaf401bfb", "AQAAAAIAAYagAAAAEPkuw45PNJMo4teDaLZWJZiwiQdzFRq5UNoKJOrwNOmBL10nLfxhVRik+W2ara+ItA==", "cd75b8fc-a7d0-43b7-938d-2ffe0feda802" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchCriteria");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "MatchedBy",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "MatchedOnCriteria",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "UserId_One",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "UserId_Two",
                table: "Match");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Profile",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "MatchParticipant",
                columns: table => new
                {
                    MatchParticipantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchParticipant", x => x.MatchParticipantId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ab74521-f017-4714-9f51-50d45a525caf", "AQAAAAIAAYagAAAAEFCn5YvOu6SuHTEdD7w2TT7PXA39gXb+2XhqPnxhccm3GS6BPIVhnjCmLHi0eXPT1w==", "4ca30b0b-6f19-43a4-a01b-e2f29a0213c1" });
        }
    }
}
