using Sistema_de_Inventario.DTOs.Categoria;

namespace Sistema_de_Inventario.Abstracciones.Servicios
{
    public interface IServicioCategoria
    {
        List<CategoriaDTO> Get();
        CategoriaDTO? GetById(int id);
        CategoriaDTO? Crear(CrearCategoriaDTO crearCategoriaDTO);
        CategoriaDTO Actualizar(int id, ActualizarCategoriaDTO actualizarCategoriaDTO);
        void Borrar(int id);
    }
}
