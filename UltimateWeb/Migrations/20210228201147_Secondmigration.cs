using Microsoft.EntityFrameworkCore.Migrations;

namespace UltimateWeb.Migrations
{
    public partial class Secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TreinadorCPF",
                table: "Aluno",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Treinador",
                columns: table => new
                {
                    CPF = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    Categoria = table.Column<string>(nullable: true),
                    Idade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treinador", x => x.CPF);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_TreinadorCPF",
                table: "Aluno",
                column: "TreinadorCPF");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Treinador_TreinadorCPF",
                table: "Aluno",
                column: "TreinadorCPF",
                principalTable: "Treinador",
                principalColumn: "CPF",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Treinador_TreinadorCPF",
                table: "Aluno");

            migrationBuilder.DropTable(
                name: "Treinador");

            migrationBuilder.DropIndex(
                name: "IX_Aluno_TreinadorCPF",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "TreinadorCPF",
                table: "Aluno");
        }
    }
}
