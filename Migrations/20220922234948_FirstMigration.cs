using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COSTS_API.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(6)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(25)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "projetos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(6)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(25)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    orcamento = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    categoria = table.Column<int>(type: "int(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projetos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_projetos_categorias_categoria",
                        column: x => x.categoria,
                        principalTable: "categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "servicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(6)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(25)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    orcamento = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    projeto = table.Column<int>(type: "int(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_servicos_projetos_projeto",
                        column: x => x.projeto,
                        principalTable: "projetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_projetos_categoria",
                table: "projetos",
                column: "categoria");

            migrationBuilder.CreateIndex(
                name: "IX_servicos_projeto",
                table: "servicos",
                column: "projeto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "servicos");

            migrationBuilder.DropTable(
                name: "projetos");

            migrationBuilder.DropTable(
                name: "categorias");
        }
    }
}
