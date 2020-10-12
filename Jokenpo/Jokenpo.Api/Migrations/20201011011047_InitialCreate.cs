using Microsoft.EntityFrameworkCore.Migrations;

namespace Jokenpo.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jogadores",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    SobreNome = table.Column<string>(nullable: true),
                    movimentos = table.Column<int>(nullable: false),
                    CaminhoFoto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogadores", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Jogadores",
                columns: new[] { "id", "CaminhoFoto", "Nome", "SobreNome", "movementos" },
                values: new object[,]
                {
                    { 1, "imagens/pedra.png", "Pedro", "asd", 0 },
                    { 2, "imagens/pedra.png", "Pedro", "asd", 0 },
                    { 3, "imagens/papel.png", "Pedro", "asd", 0 },
                    { 4, "imagens/tesoura.png", "Pedro", "asd", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogadores");
        }
    }
}
