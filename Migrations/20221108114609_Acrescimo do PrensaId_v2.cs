using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Programa6.Migrations
{
    /// <inheritdoc />
    public partial class AcrescimodoPrensaIdv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrensaId",
                table: "ResumoPrensas",
                newName: "Prensa");

            migrationBuilder.RenameColumn(
                name: "PrensaId",
                table: "DadosPrensas",
                newName: "Prensa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Prensa",
                table: "ResumoPrensas",
                newName: "PrensaId");

            migrationBuilder.RenameColumn(
                name: "Prensa",
                table: "DadosPrensas",
                newName: "PrensaId");
        }
    }
}
