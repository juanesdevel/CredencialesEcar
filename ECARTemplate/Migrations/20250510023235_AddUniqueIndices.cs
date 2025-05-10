using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECARTemplate.Migrations
{
    public partial class AddUniqueIndices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CodigoUsuarioEcar",
                table: "Usuarios",
                column: "CodigoUsuarioEcar",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_CodigoEquipo",
                table: "Equipos",
                column: "CodigoEquipo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Usuarios_CodigoUsuarioEcar",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_CodigoEquipo",
                table: "Equipos");
        }
    }
}
