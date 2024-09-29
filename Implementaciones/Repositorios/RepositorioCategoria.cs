using Sistema_de_Inventario.Abstracciones.Repositorios;

using Sistema_de_Inventario.DTOs.Categoria;
using Sistema_de_Inventario.Models;

namespace Sistema_de_Inventario.Implementaciones.Repositorios
{
    public class RepositorioCategoria : IRepositorioCategoria
    {
        private readonly InventorySystemContext _context;
        public RepositorioCategoria(InventorySystemContext context)
        {
            _context = context;
        }

        public Categoria Actualizar(int id, ActualizarCategoriaDTO actualizarCategoriaDTO)
        {
            var categoriaActual = GetById(id);

            if (categoriaActual == null)
            {
                throw new Exception();
            }

            categoriaActual.Nombre = actualizarCategoriaDTO.Nombre ?? actualizarCategoriaDTO.Nombre;
            categoriaActual.Descripcion = actualizarCategoriaDTO.Descripcion ?? actualizarCategoriaDTO.Descripcion;


            var result = _context.Update(categoriaActual);
            _context.SaveChanges();
            return result.Entity;
        }

        public Categoria? Crear(CrearCategoriaDTO crearCategoriaDTO)
        {
            var categoria = new Categoria
            {
                Nombre = crearCategoriaDTO.Nombre,
                Descripcion = crearCategoriaDTO.Descripcion,
                FechaCreacion = DateTime.Now
            };

            var result = _context.Add(categoria);
            _context.SaveChanges();

            return result.Entity;
        }

        public void Borrar(int id)
        {
            var borrar = GetById(id);

            if(borrar == null)
            {
                throw new Exception("Usuario no Encontrado");
            }

            _context.Categoria.Remove(borrar);
            _context.SaveChanges();
        }

        public List<Categoria> Get()
        {
            return [.. _context.Categoria];
        }

        public Categoria? GetById(int id)
        {
            return _context.Categoria.Where(p => p.CategoriaId == id).FirstOrDefault();
        }
    }
}
