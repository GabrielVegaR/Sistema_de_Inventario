using System.Diagnostics;

namespace Sistema_de_Inventario.DTOs.Pedido
{
    public class PedidoDTO
    {
        public int PedidoId { get; set; }
        public Decimal Total { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
