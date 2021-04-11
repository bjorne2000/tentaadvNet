using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendHamster.Migrations
{
    public partial class laTillSakerJagMissat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hamsters_cages_CageID",
                table: "hamsters");

            migrationBuilder.DropForeignKey(
                name: "FK_hamsters_motionsyta_MotionsytaID",
                table: "hamsters");

            migrationBuilder.DropIndex(
                name: "IX_hamsters_CageID",
                table: "hamsters");

            migrationBuilder.DropIndex(
                name: "IX_hamsters_MotionsytaID",
                table: "hamsters");

            migrationBuilder.DropColumn(
                name: "CageID",
                table: "hamsters");

            migrationBuilder.DropColumn(
                name: "MotionsytaID",
                table: "hamsters");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CageID",
                table: "hamsters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotionsytaID",
                table: "hamsters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_hamsters_CageID",
                table: "hamsters",
                column: "CageID");

            migrationBuilder.CreateIndex(
                name: "IX_hamsters_MotionsytaID",
                table: "hamsters",
                column: "MotionsytaID");

            migrationBuilder.AddForeignKey(
                name: "FK_hamsters_cages_CageID",
                table: "hamsters",
                column: "CageID",
                principalTable: "cages",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_hamsters_motionsyta_MotionsytaID",
                table: "hamsters",
                column: "MotionsytaID",
                principalTable: "motionsyta",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
