using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ProyectoMejorado.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(100)]
        public string NombreCompleto { get; set; } = "";

        [Required]
        [MaxLength(250)]
        public string Direccion { get; set; } = "";

        [Required]
        [Phone]
        public string Telefono { get; set; } = "";
    }

}
