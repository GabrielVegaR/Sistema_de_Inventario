namespace Sistema_de_Inventario.DTOs.Producto
{
    public class ProductoDTO
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int? IdCategoria { get; set; } 
        public int? IdProveedor { get; set; } 
        public DateTime FechaCreacion { get; set; }
    }
}
