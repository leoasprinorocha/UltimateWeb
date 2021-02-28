using Microsoft.EntityFrameworkCore.Migrations;

namespace UltimateWeb.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Cpf = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    idade = table.Column<int>(nullable: false),
                    Categoria = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Cpf);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluno");
        }
    }
}
