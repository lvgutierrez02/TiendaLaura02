using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaLaura.DAL.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colores",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreColor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colores", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "TiposPrenda",
                columns: table => new
                {
                    TipoPrendaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoPrendaNombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposPrenda", x => x.TipoPrendaId);
                });

            migrationBuilder.CreateTable(
                name: "Prendas",
                columns: table => new
                {
                    PrendaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePrenda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: true),
                    TipoPrendaId = table.Column<int>(type: "int", nullable: true),
                    ColorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prendas", x => x.PrendaId);
                    table.ForeignKey(
                        name: "FK_Prendas_Colores_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colores",
                        principalColumn: "ColorId");
                    table.ForeignKey(
                        name: "FK_Prendas_TiposPrenda_TipoPrendaId",
                        column: x => x.TipoPrendaId,
                        principalTable: "TiposPrenda",
                        principalColumn: "TipoPrendaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prendas_ColorId",
                table: "Prendas",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Prendas_TipoPrendaId",
                table: "Prendas",
                column: "TipoPrendaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prendas");

            migrationBuilder.DropTable(
                name: "Colores");

            migrationBuilder.DropTable(
                name: "TiposPrenda");
        }
    }
}
