using Sistema_de_Inventario.DTOs.Categoria;
using Sistema_de_Inventario.DTOs.Producto;
using Sistema_de_Inventario.Models;

namespace Sistema_de_Inventario.Abstracciones.Repositorios
{
    public interface IRepositorioProducto
    {
        List<Producto> Get();
        Producto? GetById(int id);
        Producto? Crear(CrearProductoDTO crearProductoDTO);
        Producto Actializar(int id, ActualizarProductoDTO actualizarProductoDTO);
        void Borrar(int id);
    }
}
