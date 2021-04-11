using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendHamster.Migrations
{
    public partial class initialMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cageNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "motionsyta",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motionsyta", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "hamsters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ownerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<int>(type: "int", nullable: false),
                    senastMotioneradTid = table.Column<DateTime>(type: "datetime2", nullable: false),
                    inCheck = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CageID = table.Column<int>(type: "int", nullable: true),
                    MotionsytaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hamsters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_hamsters_cages_CageID",
                        column: x => x.CageID,
                        principalTable: "cages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_hamsters_motionsyta_MotionsytaID",
                        column: x => x.MotionsytaID,
                        principalTable: "motionsyta",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "logg",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hamsterLoggID = table.Column<int>(type: "int", nullable: true),
                    timeLogg = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logg", x => x.ID);
                    table.ForeignKey(
                        name: "FK_logg_hamsters_hamsterLoggID",
                        column: x => x.hamsterLoggID,
                        principalTable: "hamsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hamsters_CageID",
                table: "hamsters",
                column: "CageID");

            migrationBuilder.CreateIndex(
                name: "IX_hamsters_MotionsytaID",
                table: "hamsters",
                column: "MotionsytaID");

            migrationBuilder.CreateIndex(
                name: "IX_logg_hamsterLoggID",
                table: "logg",
                column: "hamsterLoggID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "logg");

            migrationBuilder.DropTable(
                name: "hamsters");

            migrationBuilder.DropTable(
                name: "cages");

            migrationBuilder.DropTable(
                name: "motionsyta");
        }
    }
}
