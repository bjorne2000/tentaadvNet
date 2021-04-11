using Microsoft.EntityFrameworkCore.Migrations;


namespace BackendHamster.Migrations
{
    public partial class aktivitetsLogg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "aktivitet",
                table: "logg",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "aktivitet",
                table: "logg");
        }
    }
}
