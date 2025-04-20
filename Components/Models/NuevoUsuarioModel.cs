using System.ComponentModel.DataAnnotations;

namespace ProyectoMejorado.Components.Models
{
    public class NuevoUsuarioModel
    {
        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, MinLength(6)]
        public string Contrasena { get; set; } = string.Empty;

        [Required]
        public string Rol { get; set; } = string.Empty;
    }
}
