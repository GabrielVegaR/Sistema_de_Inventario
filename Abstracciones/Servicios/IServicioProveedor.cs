using Sistema_de_Inventario.DTOs.Categoria;
using Sistema_de_Inventario.DTOs.Proveedor;

namespace Sistema_de_Inventario.Abstracciones.Servicios
{
    public interface IServicioProveedor
    {
        List<ProveedorDTO> Get();
        ProveedorDTO? GetById(int id);
        ProveedorDTO? Crear(CrearProveedorDTO crearProveedorDTO);
        ProveedorDTO Actualizar(int id, ActualizarProveedorDTO actualizarProveedorDTO);
        void Borrar(int id);
    }
}
