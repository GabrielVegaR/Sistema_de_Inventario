using Sistema_de_Inventario.DTOs.Categoria;
using Sistema_de_Inventario.DTOs.Pedido;
using Sistema_de_Inventario.Models;

namespace Sistema_de_Inventario.Abstracciones.Repositorios
{
    public class IRepositorioPedido
    {
        List<Pedido> Get();
        Pedido? GetById(int id);
        Pedido? Crear(CrearPedidoDTO crearPedidoDTO);
        void Borrar(int id);
    }
}
