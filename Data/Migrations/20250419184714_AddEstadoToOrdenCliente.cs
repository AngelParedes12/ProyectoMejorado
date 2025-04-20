using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoMejorado.Migrations
{
    /// <inheritdoc />
    public partial class AddEstadoToOrdenCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "OrdenesClientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "OrdenesClientes");
        }
    }
}
