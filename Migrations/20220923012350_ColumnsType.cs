using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COSTS_API.Migrations
{
    public partial class ColumnsType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "projeto",
                table: "servicos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(6)");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "servicos",
                type: "varchar(60)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(25)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "servicos",
                type: "varchar(120)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(25)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "projetos",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(25)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "categoria",
                table: "projetos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(6)");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "projetos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(6)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "categorias",
                type: "varchar(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(25)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "categorias",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(6)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "projeto",
                table: "servicos",
                type: "int(6)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "servicos",
                type: "varchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(60)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "servicos",
                type: "varchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(120)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "projetos",
                type: "varchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "categoria",
                table: "projetos",
                type: "int(6)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "projetos",
                type: "int(6)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "categorias",
                type: "varchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(40)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "categorias",
                type: "int(6)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);
        }
    }
}
