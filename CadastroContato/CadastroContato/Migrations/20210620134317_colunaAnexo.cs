using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroContato.Migrations
{
    public partial class colunaAnexo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "anexo",
                table: "Contatos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "anexo",
                table: "Contatos");
        }
    }
}
