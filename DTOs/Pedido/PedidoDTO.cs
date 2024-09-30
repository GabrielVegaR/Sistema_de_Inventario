using Sistema_de_Inventario.DTOs.ProductosPedido;
using System.Diagnostics;

namespace Sistema_de_Inventario.DTOs.Pedido
{
    public class PedidoDTO
    {
        public int PedidoId { get; set; }
        public Decimal Total { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<ProductosPedidoDTO> Productos { get; set; } = new List<ProductosPedidoDTO>();

        public static PedidoDTO ConvertirAPedidoDTO(Sistema_de_Inventario.Models.Pedido pedido)
        {
            return new PedidoDTO
            {
                Total = pedido.Total,
                FechaCreacion = (DateTime)pedido.FechaCreacion,
                Productos = pedido.ProductosPedidos.Select(pp => new ProductosPedidoDTO
                {
                    IdProducto = pp.IdProducto,
                    Cantidad = pp.Cantidad,
                    PrecioUnidad = pp.PrecioUnidad,
                    FechaCreacion = (DateTime)pp.FechaCreacion
                }).ToList()
            };
        }
    }
}
