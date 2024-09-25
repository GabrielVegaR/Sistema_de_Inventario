using Sistema_de_Inventario.DTOs.Categoria;
using Sistema_de_Inventario.DTOs.Proveedor;
using Sistema_de_Inventario.Models;

namespace Sistema_de_Inventario.Abstracciones.Repositorios
{
    public class IRepositorioProveedor
    {
        List<Proveedor> Get();
        Proveedor? GetById(int id);
        Proveedor? Crear(CrearProveedorDTO crearProveedorDTO);
        Proveedor Actializar(int id, ActualizarProveedorDTO actualizarProveedorDTO);
        void Borrar(int id);
    }
}
