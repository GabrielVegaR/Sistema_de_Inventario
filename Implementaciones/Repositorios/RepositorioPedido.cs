using Microsoft.EntityFrameworkCore;
using Sistema_de_Inventario.Abstracciones.Repositorios;

using Sistema_de_Inventario.DTOs.Pedido;
using Sistema_de_Inventario.Models;
using System;

namespace Sistema_de_Inventario.Implementaciones.Repositorios
{
    public class RepositorioPedido : IRepositorioPedido
    {
        private readonly InventorySystemContext _context;
        public RepositorioPedido(InventorySystemContext context)
        {
            _context = context;
        }

        public Pedido Crear(CrearPedidoDTO crearPedidoDTO)
        {
            var total = 0m; // Inicializa el total
            var productosPedidos = new List<ProductosPedido>(); // Lista para los productos del pedido

            foreach (var productoDTO in crearPedidoDTO.Productos)
            {
                // Buscar el producto actual en la base de datos usando el ID
                var producto = _context.Productos.FirstOrDefault(p => p.ProductoId == productoDTO.IdProducto);
                if (producto == null)
                {
                    throw new Exception($"Producto con ID {productoDTO.IdProducto} no encontrado.");
                }

                // Calcular el total acumulado
                total += producto.Precio * productoDTO.Cantidad;

                // Agregar el producto a la lista
                productosPedidos.Add(new ProductosPedido
                {
                    IdProducto = producto.ProductoId,
                    Cantidad = productoDTO.Cantidad,
                    PrecioUnidad = producto.Precio, // Asignar el precio del producto encontrado
                    FechaCreacion = DateTime.Now
                });
            }

            var pedido = new Pedido
            {
                Total = total, // Asigna el total calculado
                FechaCreacion = DateTime.Now,
                ProductosPedidos = productosPedidos // Asigna la lista de productos
            };

            var result = _context.Pedidos.Add(pedido);
            _context.SaveChanges();
            return result.Entity;
        }

        public Pedido Actualizar(int id, ActualizarPedidoDTO actualizarPedidoDTO)
        {
            var pedidoActual = GetById(id);

            if (pedidoActual == null)
            {
                throw new Exception("Pedido no encontrado");
            }

            pedidoActual.Total = actualizarPedidoDTO.Total;
            pedidoActual.ProductosPedidos = (ICollection<ProductosPedido>)(actualizarPedidoDTO.Productos ?? actualizarPedidoDTO.Productos);

            var result = _context.Update(pedidoActual); 
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
        }

        public List<Pedido> Get()
        {
            return _context.Pedidos
                .Include(p => p.ProductosPedidos) 
                .ToList();
        }

        public Pedido? GetById(int id) 
        {
            return _context.Pedidos.Where(p => p.PedidoId == id).FirstOrDefault();

        }
    }
}
