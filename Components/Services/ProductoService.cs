using Microsoft.EntityFrameworkCore;
using ProyectoMejorado.Components.Models;
using ProyectoMejorado.Data;

namespace ProyectoMejorado.Components.Services
{
    public class ProductoService
    {
        private readonly ApplicationDbContext _context;

        public ProductoService(ApplicationDbContext context)
        {
            _context = context;
        }

        // ✅ Nuevo método para mostrar todos los productos, incluyendo los que tienen 0 stock
        public async Task<List<Producto>> ObtenerTodosParaTienda()
        {
            return await _context.Productos
                .OrderByDescending(p => p.CantidadDisponible > 0)
                .ThenByDescending(p => p.Id)
                .ToListAsync();
        }

        // ✅ Método anterior para el inventario interno (si deseas mantenerlo separado)
        public async Task<List<Producto>> ObtenerTodos()
        {
            return await _context.Productos
                .OrderByDescending(p => p.Id)
                .ToListAsync();
        }

        // ❌ Solo productos con stock, ya no se usa para la tienda
        public async Task<List<Producto>> ObtenerProductos()
        {
            return await _context.Productos
                .Where(p => p.CantidadDisponible > 0)
                .OrderByDescending(p => p.Id)
                .ToListAsync();
        }

        public async Task AgregarProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();
        }

        public async Task<Producto?> ObtenerPorId(int id)
        {
            return await _context.Productos.FindAsync(id);
        }

        public async Task EliminarProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                await _context.SaveChangesAsync();
            }
        }

        public async Task ActualizarProducto(Producto producto)
        {
            _context.Productos.Update(producto);
            await _context.SaveChangesAsync();
        }
    }
}
