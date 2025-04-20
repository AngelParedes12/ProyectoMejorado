using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoMejorado.Components.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Categoria { get; set; }
        public decimal Precio { get; set; }
        public int CantidadDisponible { get; set; }
        public string? ImagenUrl { get; set; }

        [NotMapped]
        public int StockExtra { get; set; }

    }
}
