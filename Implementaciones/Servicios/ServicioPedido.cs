using Sistema_de_Inventario.Abstracciones.Repositorios;
using Sistema_de_Inventario.Abstracciones.Servicios;
using Sistema_de_Inventario.DTOs.Pedido;
using Sistema_de_Inventario.DTOs.ProductosPedido;
using Sistema_de_Inventario.Models;

namespace Sistema_de_Inventario.Implementaciones.Servicios
{
    public class ServicioPedido : IServicioPedido
    {
        private readonly IRepositorioPedido repositorioPedido;
        public ServicioPedido(IRepositorioPedido repositorioPedido)
        {
            this.repositorioPedido = repositorioPedido;
        }

        public PedidoDTO? Crear(CrearPedidoDTO crearPedidoDTO)
        {
            var pedidoCreado = repositorioPedido.Crear(crearPedidoDTO);

            if (pedidoCreado == null)
            {
                return null;
            }

            var pedidoDTO = PedidoDTO.ConvertirAPedidoDTO(pedidoCreado);
            return pedidoDTO;
        }

        public PedidoDTO Actualizar(int id, ActualizarPedidoDTO actualizarPedidoDTO)
        {
            var pedido = repositorioPedido.Actualizar(id, actualizarPedidoDTO);

            var pedidoDTO = PedidoDTO.ConvertirAPedidoDTO(pedido);

            return pedidoDTO;
        }

        public void Borrar(int id)
        {
            repositorioPedido.Borrar(id);
        }

        public List<PedidoDTO> Get()
        {
            var listaPedidos = repositorioPedido.Get();
            var pedidoDTO = new List<PedidoDTO>();

            foreach (var pedido in listaPedidos)
            {
                var productosDTO = pedido.ProductosPedidos.Select(p => new ProductosPedidoDTO
                {
                    IdProducto = p.IdProducto,
                    Cantidad = p.Cantidad,
                    PrecioUnidad = p.PrecioUnidad,
                    FechaCreacion = (DateTime)p.FechaCreacion
                }).ToList();

                var result = new PedidoDTO
                {
                    PedidoId = pedido.PedidoId,
                    Total = pedido.Total,
                    FechaCreacion = (DateTime)pedido.FechaCreacion,
                    Productos = productosDTO 
                };

                pedidoDTO.Add(result);
            }

            return pedidoDTO;
        }

        public PedidoDTO? GetById(int id)
        {
            var pedido = repositorioPedido.GetById(id);

            var pedidoDTO = PedidoDTO.ConvertirAPedidoDTO(pedido);

            return pedidoDTO;
        }
    }
}
