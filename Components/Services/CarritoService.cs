using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using ProyectoMejorado.Components.Models;

namespace ProyectoMejorado.Components.Services
{
    public class CarritoService
    {
        private List<ItemCarrito> carrito = new();
        private readonly ProtectedLocalStorage localStorage;
        private const string StorageKey = "carrito";

        public event Action? OnChange;

        public CarritoService(ProtectedLocalStorage localStorage)
        {
            this.localStorage = localStorage;
            _ = CargarCarrito();
        }

        public IReadOnlyList<ItemCarrito> ObtenerItems() => carrito;

        public void Agregar(ItemCarrito item)
        {
            var existente = carrito.FirstOrDefault(i => i.ProductoId == item.ProductoId);
            if (existente != null)
                existente.Cantidad += item.Cantidad;
            else
                carrito.Add(item);

            GuardarCarrito();
            NotificarCambio();
        }

        public void Quitar(int productoId)
        {
            var item = carrito.FirstOrDefault(i => i.ProductoId == productoId);
            if (item != null)
                carrito.Remove(item);

            GuardarCarrito();
            NotificarCambio();
        }

        public void Limpiar()
        {
            carrito.Clear();
            GuardarCarrito();
            NotificarCambio();
        }

        public decimal ObtenerTotal() =>
            carrito.Sum(i => i.Precio * i.Cantidad);

        public int ObtenerCantidadTotal() =>
            carrito.Sum(i => i.Cantidad);

        public void AumentarCantidad(int productoId)
        {
            var item = carrito.FirstOrDefault(i => i.ProductoId == productoId);
            if (item != null)
            {
                item.Cantidad++;
                GuardarCarrito();
                NotificarCambio();
            }
        }

        public void DisminuirCantidad(int productoId)
        {
            var item = carrito.FirstOrDefault(i => i.ProductoId == productoId);
            if (item != null && item.Cantidad > 1)
            {
                item.Cantidad--;
                GuardarCarrito();
                NotificarCambio();
            }
        }

        public void EliminarItem(int productoId)
        {
            var item = carrito.FirstOrDefault(i => i.ProductoId == productoId);
            if (item != null)
            {
                carrito.Remove(item);
                GuardarCarrito();
                NotificarCambio();
            }
        }

        private async void GuardarCarrito()
        {
            await localStorage.SetAsync(StorageKey, carrito);
        }

        private async Task CargarCarrito()
        {
            var resultado = await localStorage.GetAsync<List<ItemCarrito>>(StorageKey);
            if (resultado.Success && resultado.Value is not null)
                carrito = resultado.Value;

            NotificarCambio();
        }

        private void NotificarCambio() => OnChange?.Invoke();
    }
}
