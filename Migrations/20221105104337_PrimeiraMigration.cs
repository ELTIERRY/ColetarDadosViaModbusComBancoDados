using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Programa6.Migrations
{
    /// <inheritdoc />
    public partial class PrimeiraMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DadosPrensas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemperaturaPlato01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemperaturaPlato02 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosPrensas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResumoPrensas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temp1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temp2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumoPrensas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DadosPrensas");

            migrationBuilder.DropTable(
                name: "ResumoPrensas");
        }
    }
}
