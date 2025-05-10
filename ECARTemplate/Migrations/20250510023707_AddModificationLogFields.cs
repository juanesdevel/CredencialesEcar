using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECARTemplate.Migrations
{
    public partial class AddModificationLogFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                table: "Usuarios",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                table: "Equipos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                table: "Credenciales",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "Credenciales");
        }
    }
}
