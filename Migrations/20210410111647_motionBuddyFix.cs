using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendHamster.Migrations
{
    public partial class motionBuddyFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_motionBuddies_motionsyta_motionID",
                table: "motionBuddies");

            migrationBuilder.DropIndex(
                name: "IX_motionBuddies_motionID",
                table: "motionBuddies");

            migrationBuilder.DropColumn(
                name: "motionID",
                table: "motionBuddies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "motionID",
                table: "motionBuddies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_motionBuddies_motionID",
                table: "motionBuddies",
                column: "motionID");

            migrationBuilder.AddForeignKey(
                name: "FK_motionBuddies_motionsyta_motionID",
                table: "motionBuddies",
                column: "motionID",
                principalTable: "motionsyta",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
