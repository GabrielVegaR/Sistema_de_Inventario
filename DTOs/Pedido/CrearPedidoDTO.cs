﻿using Sistema_de_Inventario.DTOs.ProductosPedido;

namespace Sistema_de_Inventario.DTOs.Pedido
{
    public class CrearPedidoDTO
    {
        public Decimal Total { get; set; }
        public List<CrearProductosPedidosDTO> Productos { get; set; } = new List<CrearProductosPedidosDTO>();
    }
}

