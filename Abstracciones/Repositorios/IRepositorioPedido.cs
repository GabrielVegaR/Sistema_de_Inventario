using Sistema_de_Inventario.DTOs.Categoria;
using Sistema_de_Inventario.DTOs.Pedido;
using Sistema_de_Inventario.Models;

namespace Sistema_de_Inventario.Abstracciones.Repositorios
{
    public interface IRepositorioPedido
    {
        List<Pedido> Get();
        Pedido? GetById(int id);
        Pedido? Crear(CrearPedidoDTO crearPedidoDTO);
        Pedido Actualizar(int id, ActualizarPedidoDTO actualizarPedidoDTO);
        void Borrar(int id);
    }
}
