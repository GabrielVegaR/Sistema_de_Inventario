namespace Sistema_de_Inventario.DTOs.ProductosPedido
{
    public class ProductosPedidoDTO
    {
        public int IdPedido { get; set; }
        public int IdProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnidad { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
