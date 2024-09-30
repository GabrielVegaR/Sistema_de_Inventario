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

        public static ProductoDTO ConvertirAProductoDTO(Sistema_de_Inventario.Models.Producto producto)
        {
            if (producto == null)
            {
                throw new ArgumentNullException(nameof(producto), "El producto no puede ser nulo.");
            }

            return new ProductoDTO
            {
                ProductoId = producto.ProductoId,
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                Precio = producto.Precio,
                Stock = producto.Stock,
                IdCategoria = producto.IdCategoria,
                IdProveedor = producto.IdProveedor
            };
        }
    }
}
