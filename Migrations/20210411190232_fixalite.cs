using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendHamster.Migrations
{
    public partial class fixalite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "motionBuddies");

            migrationBuilder.DropColumn(
                name: "aktiv",
                table: "logg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "aktiv",
                table: "logg",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "motionBuddies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    activeHamsterID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motionBuddies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_motionBuddies_hamsters_activeHamsterID",
                        column: x => x.activeHamsterID,
                        principalTable: "hamsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_motionBuddies_activeHamsterID",
                table: "motionBuddies",
                column: "activeHamsterID");
        }
    }
}
