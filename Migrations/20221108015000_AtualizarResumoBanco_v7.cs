using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Programa6.Migrations
{
    /// <inheritdoc />
    public partial class AtualizarResumoBancov7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResumoPrensas");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "DadosPrensas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "DadosPrensas");

            migrationBuilder.CreateTable(
                name: "ResumoPrensas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemperaturaPlato01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemperaturaPlato02 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumoPrensas", x => x.Id);
                });
        }
    }
}
