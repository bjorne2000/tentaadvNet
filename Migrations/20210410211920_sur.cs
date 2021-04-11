using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendHamster.Migrations
{
    public partial class sur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "motionsBatch",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    activeHamsterID = table.Column<int>(type: "int", nullable: true),
                    ytaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motionsBatch", x => x.ID);
                    table.ForeignKey(
                        name: "FK_motionsBatch_hamsters_activeHamsterID",
                        column: x => x.activeHamsterID,
                        principalTable: "hamsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_motionsBatch_motionsyta_ytaID",
                        column: x => x.ytaID,
                        principalTable: "motionsyta",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_motionsBatch_activeHamsterID",
                table: "motionsBatch",
                column: "activeHamsterID");

            migrationBuilder.CreateIndex(
                name: "IX_motionsBatch_ytaID",
                table: "motionsBatch",
                column: "ytaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "motionsBatch");
        }
    }
}
