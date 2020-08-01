using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DeberPrograPao1.Migrations
{
    public partial class PersonaFoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Foto",
                table: "Personas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Personas");
        }
    }
}
