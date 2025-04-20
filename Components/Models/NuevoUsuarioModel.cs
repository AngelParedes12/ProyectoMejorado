using System.ComponentModel.DataAnnotations;

namespace ProyectoMejorado.Components.Models
{
    public class NuevoUsuarioModel
    {
        [Required(ErrorMessage = "El nombre completo es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no debe exceder los 100 caracteres.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [MinLength(6, ErrorMessage = "La contraseña debe tener al menos 6 caracteres.")]
        public string Contrasena { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe seleccionar un rol para el usuario.")]
        public string Rol { get; set; } = string.Empty;
    }
}
