using Sistema_de_Inventario.Models;
using Sistema_de_Inventario.Abstracciones.Repositorios;
using Sistema_de_Inventario.DTOs.ProductosPedido;

namespace Sistema_de_Inventario.Implementaciones.Repositorios
{
    public class RepositorioProductosPedido : IRepositorioProductosPedido
    {
        private readonly InventorySystemContext _context;
        public RepositorioProductosPedido(InventorySystemContext context)
        {
            _context = context;
        }

        public ProductosPedido Actualizar(int id, ActualizarProductosPedidosDTO actualizarProductosPedidosDTO)
        {
            var productoPedidoActual = GetById(id);

            if (productoPedidoActual == null)
            {
                throw new Exception();
            }

            productoPedidoActual.PrecioUnidad = (decimal)(actualizarProductosPedidosDTO.PrecioUnidad ?? actualizarProductosPedidosDTO.PrecioUnidad);
            productoPedidoActual.Cantidad = (decimal)(actualizarProductosPedidosDTO.Cantidad ?? actualizarProductosPedidosDTO.Cantidad);

            var result = _context.Update(productoPedidoActual);
            _context.SaveChanges();
            return result.Entity;
        }
        public ProductosPedido Crear(CrearProductosPedidosDTO crearProductosPedidosDTO)
        {
            var productosPedidos = new ProductosPedido
            {
                Cantidad = crearProductosPedidosDTO.Cantidad,
                PrecioUnidad = crearProductosPedidosDTO.PrecioUnidad,
                FechaCreacion = DateTime.Now
            };

            var result = _context.Add(productosPedidos);
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

            _context.ProductosPedidos.Remove(borrar);
            _context.SaveChanges();
        }

        public List<ProductosPedido> Get()
        {
            return [.. _context.ProductosPedidos];
        }

        public ProductosPedido? GetById(int id)
        {
            return _context.ProductosPedidos.Where(p => p.IdPedido == id && p.IdProducto == id).FirstOrDefault();
        }
    }
}
