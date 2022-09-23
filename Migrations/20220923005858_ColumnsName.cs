using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COSTS_API.Migrations
{
    public partial class ColumnsName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "servicos",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "servicos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "projetos",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "projetos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "categorias",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "categorias",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "descricao",
                table: "servicos",
                type: "varchar(25)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "descricao",
                table: "servicos");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "servicos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "servicos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "projetos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "projetos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "categorias",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "categorias",
                newName: "Id");
        }
    }
}
