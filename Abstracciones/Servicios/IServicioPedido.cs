using Sistema_de_Inventario.DTOs.Pedido;

namespace Sistema_de_Inventario.Abstracciones.Servicios
{
    public interface IServicioPedido
    {
        List<PedidoDTO> Get();
        PedidoDTO? GetById(int id);
        PedidoDTO? Crear(CrearPedidoDTO crearPedidoDTO);
        PedidoDTO Actualizar(int id, ActualizarPedidoDTO actualizarPedidoDTO);
        void Borrar(int id);
    }
}
