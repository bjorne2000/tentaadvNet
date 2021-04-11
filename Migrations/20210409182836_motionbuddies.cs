using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendHamster.Migrations
{
    public partial class motionbuddies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_motionsyta_hamsters_aktivHamsterFiveID",
                table: "motionsyta");

            migrationBuilder.DropForeignKey(
                name: "FK_motionsyta_hamsters_aktivHamsterFourID",
                table: "motionsyta");

            migrationBuilder.DropForeignKey(
                name: "FK_motionsyta_hamsters_aktivHamsterOneID",
                table: "motionsyta");

            migrationBuilder.DropForeignKey(
                name: "FK_motionsyta_hamsters_aktivHamsterSixID",
                table: "motionsyta");

            migrationBuilder.DropForeignKey(
                name: "FK_motionsyta_hamsters_aktivHamsterThreeID",
                table: "motionsyta");

            migrationBuilder.DropForeignKey(
                name: "FK_motionsyta_hamsters_aktivHamsterTwoID",
                table: "motionsyta");

            migrationBuilder.DropIndex(
                name: "IX_motionsyta_aktivHamsterFiveID",
                table: "motionsyta");

            migrationBuilder.DropIndex(
                name: "IX_motionsyta_aktivHamsterFourID",
                table: "motionsyta");

            migrationBuilder.DropIndex(
                name: "IX_motionsyta_aktivHamsterOneID",
                table: "motionsyta");

            migrationBuilder.DropIndex(
                name: "IX_motionsyta_aktivHamsterSixID",
                table: "motionsyta");

            migrationBuilder.DropIndex(
                name: "IX_motionsyta_aktivHamsterThreeID",
                table: "motionsyta");

            migrationBuilder.DropIndex(
                name: "IX_motionsyta_aktivHamsterTwoID",
                table: "motionsyta");

            migrationBuilder.DropColumn(
                name: "aktivHamsterFiveID",
                table: "motionsyta");

            migrationBuilder.DropColumn(
                name: "aktivHamsterFourID",
                table: "motionsyta");

            migrationBuilder.DropColumn(
                name: "aktivHamsterOneID",
                table: "motionsyta");

            migrationBuilder.DropColumn(
                name: "aktivHamsterSixID",
                table: "motionsyta");

            migrationBuilder.DropColumn(
                name: "aktivHamsterThreeID",
                table: "motionsyta");

            migrationBuilder.DropColumn(
                name: "aktivHamsterTwoID",
                table: "motionsyta");

            migrationBuilder.CreateTable(
                name: "motionBuddies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    activeHamsterID = table.Column<int>(type: "int", nullable: true),
                    motionID = table.Column<int>(type: "int", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_motionBuddies_motionsyta_motionID",
                        column: x => x.motionID,
                        principalTable: "motionsyta",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_motionBuddies_activeHamsterID",
                table: "motionBuddies",
                column: "activeHamsterID");

            migrationBuilder.CreateIndex(
                name: "IX_motionBuddies_motionID",
                table: "motionBuddies",
                column: "motionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "motionBuddies");

            migrationBuilder.AddColumn<int>(
                name: "aktivHamsterFiveID",
                table: "motionsyta",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "aktivHamsterFourID",
                table: "motionsyta",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "aktivHamsterOneID",
                table: "motionsyta",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "aktivHamsterSixID",
                table: "motionsyta",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "aktivHamsterThreeID",
                table: "motionsyta",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "aktivHamsterTwoID",
                table: "motionsyta",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_motionsyta_aktivHamsterFiveID",
                table: "motionsyta",
                column: "aktivHamsterFiveID");

            migrationBuilder.CreateIndex(
                name: "IX_motionsyta_aktivHamsterFourID",
                table: "motionsyta",
                column: "aktivHamsterFourID");

            migrationBuilder.CreateIndex(
                name: "IX_motionsyta_aktivHamsterOneID",
                table: "motionsyta",
                column: "aktivHamsterOneID");

            migrationBuilder.CreateIndex(
                name: "IX_motionsyta_aktivHamsterSixID",
                table: "motionsyta",
                column: "aktivHamsterSixID");

            migrationBuilder.CreateIndex(
                name: "IX_motionsyta_aktivHamsterThreeID",
                table: "motionsyta",
                column: "aktivHamsterThreeID");

            migrationBuilder.CreateIndex(
                name: "IX_motionsyta_aktivHamsterTwoID",
                table: "motionsyta",
                column: "aktivHamsterTwoID");

            migrationBuilder.AddForeignKey(
                name: "FK_motionsyta_hamsters_aktivHamsterFiveID",
                table: "motionsyta",
                column: "aktivHamsterFiveID",
                principalTable: "hamsters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_motionsyta_hamsters_aktivHamsterFourID",
                table: "motionsyta",
                column: "aktivHamsterFourID",
                principalTable: "hamsters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_motionsyta_hamsters_aktivHamsterOneID",
                table: "motionsyta",
                column: "aktivHamsterOneID",
                principalTable: "hamsters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_motionsyta_hamsters_aktivHamsterSixID",
                table: "motionsyta",
                column: "aktivHamsterSixID",
                principalTable: "hamsters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_motionsyta_hamsters_aktivHamsterThreeID",
                table: "motionsyta",
                column: "aktivHamsterThreeID",
                principalTable: "hamsters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_motionsyta_hamsters_aktivHamsterTwoID",
                table: "motionsyta",
                column: "aktivHamsterTwoID",
                principalTable: "hamsters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
