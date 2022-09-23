using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COSTS_API.Migrations
{
    public partial class CorrectColumnsName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "orcamento",
                table: "servicos",
                newName: "custo");

            migrationBuilder.AddColumn<decimal>(
                name: "custo",
                table: "projetos",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "custo",
                table: "projetos");

            migrationBuilder.RenameColumn(
                name: "custo",
                table: "servicos",
                newName: "orcamento");
        }
    }
}
