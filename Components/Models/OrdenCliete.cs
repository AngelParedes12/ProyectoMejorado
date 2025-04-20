using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations;

namespace ProyectoMejorado.Components.Models
{
    public class OrdenCliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El correo del cliente es obligatorio.")]
        [EmailAddress(ErrorMessage = "El correo ingresado no es válido.")]
        public string ClienteEmail { get; set; } = "";

        [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string NombreCompleto { get; set; } = "";

        [Required(ErrorMessage = "La dirección de envío es obligatoria.")]
        [StringLength(250, ErrorMessage = "La dirección no puede exceder los 250 caracteres.")]
        public string DireccionEnvio { get; set; } = "";

        [Required(ErrorMessage = "El número de teléfono es obligatorio.")]
        [Phone(ErrorMessage = "El número de teléfono no es válido.")]
        public string Telefono { get; set; } = "";

        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;

        public decimal Total { get; set; }

        [Required(ErrorMessage = "Debes seleccionar un método de pago.")]
        [RegularExpression("Efectivo|Tarjeta|Transferencia", ErrorMessage = "El método de pago no es válido.")]
        public string MetodoPago { get; set; } = "Efectivo";

        public string Productos { get; set; } = "";

        [Required]
        public string Estado { get; set; } = "Pendiente";
    }
}
