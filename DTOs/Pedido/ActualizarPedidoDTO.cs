using Sistema_de_Inventario.DTOs.ProductosPedido;

namespace Sistema_de_Inventario.DTOs.Pedido
{
    public class ActualizarPedidoDTO
    {
        public decimal Total { get; set; }

        public List<ActualizarProductosPedidosDTO> Productos { get; set; } = new List<ActualizarProductosPedidosDTO>();     
    }
}
