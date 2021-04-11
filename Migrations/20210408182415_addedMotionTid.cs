using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendHamster.Migrations
{
    public partial class addedMotionTid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "motionTid",
                table: "motionsyta",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "motionTid",
                table: "motionsyta");
        }
    }
}
