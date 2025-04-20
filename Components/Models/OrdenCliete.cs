using System.ComponentModel.DataAnnotations;

namespace ProyectoMejorado.Components.Models
{
    public class OrdenCliente
    {
        public int Id { get; set; }

        [Required]
        public string ClienteEmail { get; set; } = "";

        [Required]
        public string NombreCompleto { get; set; } = "";

        [Required]
        public string DireccionEnvio { get; set; } = "";

        [Required]
        public string Telefono { get; set; } = "";

        public DateTime Fecha { get; set; }

        public decimal Total { get; set; }
        public string MetodoPago { get; set; } = "Efectivo"; 


        public string Productos { get; set; } = "";
        public string Estado { get; set; } = "Pendiente";
    }
}
