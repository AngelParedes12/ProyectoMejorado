using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoMejorado.Migrations
{
    /// <inheritdoc />
    public partial class AgregarMetodoPagoAOrdenCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MetodoPago",
                table: "OrdenesClientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MetodoPago",
                table: "OrdenesClientes");
        }
    }
}
