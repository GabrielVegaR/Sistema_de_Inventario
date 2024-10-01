using Sistema_de_Inventario.Abstracciones.Servicios;
using Sistema_de_Inventario.Abstracciones.Repositorios;
using Sistema_de_Inventario.DTOs.Categoria;
using Sistema_de_Inventario.Models;
using Sistema_de_Inventario.DTOs.Pedido;
using Sistema_de_Inventario.DTOs.Producto;
using Sistema_de_Inventario.Implementaciones.Repositorios;

namespace Sistema_de_Inventario.Implementaciones.Servicios
{
    public class ServicioCategoria : IServicioCategoria
    {
        private readonly IRepositorioCategoria repositorioCategoria;
        public ServicioCategoria(IRepositorioCategoria repositorioCategoria)
        {
            this.repositorioCategoria = repositorioCategoria;
        }

        public CategoriaDTO? Crear(CrearCategoriaDTO crearCategoriaDTO)
        {
            var categoria = repositorioCategoria.Crear(crearCategoriaDTO);

            if (categoria == null)
            {
                return null;
            }

            var categoriaDTO = CategoriaDTO.ConvertirACategoriaDTO(categoria);

            return categoriaDTO;
        }

        public CategoriaDTO Actualizar(int id, ActualizarCategoriaDTO actualizarCategoriaDTO)
        {
            var categoria = repositorioCategoria.Actualizar(id, actualizarCategoriaDTO);

            var categoriaDTO = CategoriaDTO.ConvertirACategoriaDTO(categoria);

            return categoriaDTO;
        }

        public void Borrar(int id)
        {
            repositorioCategoria.Borrar(id);
        }

        public List<CategoriaDTO> Get()
        {
            var listaCategoria = repositorioCategoria.Get();
            var categoriaDTO = new List<CategoriaDTO>();

            foreach (Categoria categoria in listaCategoria)
            {
                var result = CategoriaDTO.ConvertirACategoriaDTO(categoria);
                categoriaDTO.Add(result);
            }

            return categoriaDTO;
        }

        public CategoriaDTO? GetById(int id)
        {
            var categoria = repositorioCategoria.GetById(id);
            if (categoria == null)
            {
                return null;
            }

            var categoriaDTO = CategoriaDTO.ConvertirACategoriaDTO(categoria);

            return categoriaDTO;
        }
    }
}
