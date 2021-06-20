using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroContato.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    senha = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_cpf",
                table: "Contatos",
                column: "cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_email",
                table: "Contatos",
                column: "email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contatos");
        }
    }
}
