using System;
using System.Collections.Generic;

namespace Sistema_de_Inventario.Models;

public partial class ProductosPedido
{
    public int IdPedido { get; set; }

    public int IdProducto { get; set; }

    public decimal Cantidad { get; set; }

    public decimal PrecioUnidad { get; set; }

    public virtual Pedido IdPedidoNavigation { get; set; } = null!;

    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
