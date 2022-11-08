using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Programa6.Migrations
{
    /// <inheritdoc />
    public partial class AcrescimodoPrensaId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrensaId",
                table: "ResumoPrensas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrensaId",
                table: "DadosPrensas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrensaId",
                table: "ResumoPrensas");

            migrationBuilder.DropColumn(
                name: "PrensaId",
                table: "DadosPrensas");
        }
    }
}
