using Sistema_de_Inventario.DTOs.Pedido;

namespace Sistema_de_Inventario.Abstracciones.Servicios
{
    public class IServicioPedido
    {
        List<PedidoDTO> Get();
        PedidoDTO? GetById(int id);
        PedidoDTO? Crear(CrearPedidoDTO crearPedidoDTO);
        void Borrar(int id);
    }
}
