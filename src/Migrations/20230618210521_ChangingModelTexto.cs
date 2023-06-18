using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace src.Migrations
{
    /// <inheritdoc />
    public partial class ChangingModelTexto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estrutura",
                table: "Textos");

            migrationBuilder.AddColumn<string>(
                name: "Artigo",
                table: "Textos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Artigo",
                table: "Textos");

            migrationBuilder.AddColumn<int>(
                name: "Estrutura",
                table: "Textos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
