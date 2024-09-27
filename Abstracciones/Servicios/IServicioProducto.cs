using Sistema_de_Inventario.DTOs.Categoria;
using Sistema_de_Inventario.DTOs.Producto;

namespace Sistema_de_Inventario.Abstracciones.Servicios
{
    public interface IServicioProducto
    {
        List<ProductoDTO> Get();
        ProductoDTO? GetById(int id);
        ProductoDTO? Crear(CrearProductoDTO crearProductoDTO);
        ProductoDTO Actualizar(int id, ActualizarProductoDTO actualizarProductoDTO);
        void Borrar(int id);
    }
}
