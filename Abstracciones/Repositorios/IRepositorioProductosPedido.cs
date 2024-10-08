﻿using Sistema_de_Inventario.DTOs.Categoria;
using Sistema_de_Inventario.DTOs.ProductosPedido;
using Sistema_de_Inventario.Models;

namespace Sistema_de_Inventario.Abstracciones.Repositorios
{
    public interface IRepositorioProductosPedido
    {
        List<ProductosPedido> Get();
        ProductosPedido? GetById(int id);
        ProductosPedido? Crear(CrearProductosPedidosDTO crearProductosPedidosDTO);
        ProductosPedido Actualizar(int id, ActualizarProductosPedidosDTO actualizarProductosPedidosDTO);
        void Borrar(int id);
    }
}
