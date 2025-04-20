using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoMejorado.Components.Models;

namespace ProyectoMejorado.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; } 
        public DbSet<OrdenReparacion> OrdenesReparacion { get; set; }
        public DbSet<OrdenCliente> OrdenesClientes { get; set; }


    }
}
