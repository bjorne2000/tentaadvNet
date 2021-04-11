using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendHamster.Migrations
{
    public partial class addedThemBack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_motionsyta_hamsters_aktivHamsterID",
                table: "motionsyta");

            migrationBuilder.RenameColumn(
                name: "aktivHamsterID",
                table: "motionsyta",
                newName: "aktivHamsterTwoID");

            migrationBuilder.RenameIndex(
                name: "IX_motionsyta_aktivHamsterID",
                table: "motionsyta",
                newName: "IX_motionsyta_aktivHamsterTwoID");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "aktivHamsterTwoID",
                table: "motionsyta",
                newName: "aktivHamsterID");

            migrationBuilder.RenameIndex(
                name: "IX_motionsyta_aktivHamsterTwoID",
                table: "motionsyta",
                newName: "IX_motionsyta_aktivHamsterID");

            migrationBuilder.AddForeignKey(
                name: "FK_motionsyta_hamsters_aktivHamsterID",
                table: "motionsyta",
                column: "aktivHamsterID",
                principalTable: "hamsters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
