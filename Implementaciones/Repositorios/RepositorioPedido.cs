using Sistema_de_Inventario.Abstracciones.Repositorios;

using Sistema_de_Inventario.DTOs.Pedido;
using Sistema_de_Inventario.Models;

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
            var pedido = new Pedido {
            Total = crearPedidoDTO.Total,
            FechaCreacion = DateTime.Now
            };

            var result = _context.Add(pedido);
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
            return [.. _context.Pedidos];
        }

        public Pedido? GetById(int id) 
        {
            return _context.Pedidos.Where(p => p.PedidoId == id).FirstOrDefault();

        }
    }
}
