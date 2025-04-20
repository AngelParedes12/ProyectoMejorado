namespace ProyectoMejorado.Components.Models
{
    public class DashboardInfo
    {
        public int TotalProductos { get; set; }
        public int TotalPedidos { get; set; }
        public int TotalOrdenes { get; set; }
        public int TotalClientes { get; set; }
        public Dictionary<string, int> OrdenesPorEstado { get; set; } = new();
        public Dictionary<string, int> VentasPorProducto { get; set; } = new();
        public Dictionary<string, int> PedidosPorMes { get; set; } = new();
        public Dictionary<string, int> ProductosBajoStock { get; set; } = new();

    }
}
