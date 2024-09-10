using System;
using System.Collections.Generic;

namespace Sistema_de_Inventario.Models;

public partial class Pedido
{
    public int PedidoId { get; set; }

    public decimal Total { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<ProductosPedido> ProductosPedidos { get; set; } = new List<ProductosPedido>();
}
