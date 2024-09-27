using Sistema_de_Inventario.Abstracciones.Repositorios;
using Sistema_de_Inventario.DTOs.Producto;
using Sistema_de_Inventario.Models;

namespace Sistema_de_Inventario.Implementaciones.Repositorios
{
    public class RepositorioProducto : IRepositorioProducto
    {
        private readonly InventorySystemContext _context;
        public RepositorioProducto(InventorySystemContext context)
        {
            _context = context;
        }

        public Producto Actualizar(int id, ActualizarProductoDTO actualizarProductoDTO)
        {
            var productoActual = GetById(id);
            if (productoActual == null)
            {
                throw new Exception();
            }

            productoActual.Nombre = actualizarProductoDTO.Nombre ?? actualizarProductoDTO.Nombre;
            productoActual.Descripcion = actualizarProductoDTO.Descripcion ?? actualizarProductoDTO.Descripcion;
            productoActual.Precio = (decimal)(actualizarProductoDTO.Precio ?? actualizarProductoDTO.Precio);
            productoActual.Stock = (int)(actualizarProductoDTO.Stock ?? actualizarProductoDTO.Stock);

            var result = _context.Update(productoActual);
            _context.SaveChanges();

            return result.Entity;
        }


        public Producto? Crear(CrearProductoDTO crearProductoDTO)
        {
            var producto = new Producto {
                Nombre = crearProductoDTO.Nombre,
                Descripcion = crearProductoDTO.Descripcion,
                Precio = crearProductoDTO.Precio,
                Stock = crearProductoDTO.Stock,
                FechaCreacion = DateTime.Now
            };

            var result = _context.Add(producto);
            _context.SaveChanges();

            return result.Entity;
        }

        public void Borrar(int id)
        {
            var borrar = GetById(id);
            if (borrar == null)
            {
                throw new Exception("Usuario no Encontrado");
            }

            var result = _context.Remove(borrar);
            _context.SaveChanges();
        }

        public List<Producto> Get()
        {
            return [.. _context.Productos];
        }

        public Producto? GetById(int id) 
        { 
            return _context.Productos.Where(p => p.ProductoId == id).FirstOrDefault();
        }
    }
}
