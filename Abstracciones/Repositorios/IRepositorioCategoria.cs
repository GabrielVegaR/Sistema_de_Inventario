using Sistema_de_Inventario.DTOs.Categoria;
using Sistema_de_Inventario.Models;

namespace Sistema_de_Inventario.Abstracciones.Repositorios
{
    public class IRepositorioCategoria
    {
        List<Categoria> Get();
        Categoria? GetById(int id);
        Categoria? Crear(CrearCategoriaDTO crearCategoriaDTO);
        Categoria Actializar(int id, ActualizarCategoriaDTO actualizarCategoriaDTO);
        void Borrar(int id);
    }
}
