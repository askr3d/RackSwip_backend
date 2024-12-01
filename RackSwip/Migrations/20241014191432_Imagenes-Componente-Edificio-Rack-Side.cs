using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RackSwip.Migrations
{
    /// <inheritdoc />
    public partial class ImagenesComponenteEdificioRackSide : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FotoUrl",
                table: "Sides",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FotoUrl",
                table: "Racks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FotoUrl",
                table: "Edificios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FotoUrl",
                table: "Componentes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoUrl",
                table: "Sides");

            migrationBuilder.DropColumn(
                name: "FotoUrl",
                table: "Racks");

            migrationBuilder.DropColumn(
                name: "FotoUrl",
                table: "Edificios");

            migrationBuilder.DropColumn(
                name: "FotoUrl",
                table: "Componentes");
        }
    }
}
