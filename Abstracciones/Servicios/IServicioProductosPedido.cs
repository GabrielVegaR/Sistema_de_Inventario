using Sistema_de_Inventario.DTOs.Categoria;
using Sistema_de_Inventario.DTOs.ProductosPedido;

namespace Sistema_de_Inventario.Abstracciones.Servicios
{
    public class IServicioProductosPedido
    {
        List<ProductosPedidoDTO> Get();
        ProductosPedidoDTO? GetById(int id);
        ProductosPedidoDTO? Crear(CrearProductosPedidosDTO crearProductosPedidosDTO);
        ProductosPedidoDTO Actualizar(int id, ActualizarProductosPedidosDTO actualizarProductosPedidosDTO);
        void Borrar(int id);
    }
}
