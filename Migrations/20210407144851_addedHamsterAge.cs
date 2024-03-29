﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendHamster.Migrations
{
    public partial class addedHamsterAge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "hamsters",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "hamsters");
        }
    }
}
