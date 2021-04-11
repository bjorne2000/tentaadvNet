using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendHamster.Migrations
{
    public partial class MissadeMerSaker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aktiviteter",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aktiviteter", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "cageBuddies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cageHamsterID = table.Column<int>(type: "int", nullable: true),
                    filledCageID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cageBuddies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_cageBuddies_cages_filledCageID",
                        column: x => x.filledCageID,
                        principalTable: "cages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cageBuddies_hamsters_cageHamsterID",
                        column: x => x.cageHamsterID,
                        principalTable: "hamsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cageBuddies_cageHamsterID",
                table: "cageBuddies",
                column: "cageHamsterID");

            migrationBuilder.CreateIndex(
                name: "IX_cageBuddies_filledCageID",
                table: "cageBuddies",
                column: "filledCageID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aktiviteter");

            migrationBuilder.DropTable(
                name: "cageBuddies");
        }
    }
}
