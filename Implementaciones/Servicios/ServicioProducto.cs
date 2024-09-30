using Sistema_de_Inventario.Abstracciones.Repositorios;
using Sistema_de_Inventario.Abstracciones.Servicios;
using Sistema_de_Inventario.DTOs.Pedido;
using Sistema_de_Inventario.DTOs.Producto;
using Sistema_de_Inventario.Implementaciones.Repositorios;
using Sistema_de_Inventario.Models;

namespace Sistema_de_Inventario.Implementaciones.Servicios
{
    public class ServicioProducto : IServicioProducto
    {
        private readonly IRepositorioProducto repositorioProducto;

        public ServicioProducto(IRepositorioProducto repositorioProducto)
        {
            this.repositorioProducto = repositorioProducto;
        }

        public ProductoDTO? Crear(CrearProductoDTO crearProductoDTO)
        {
            var producto = repositorioProducto.Crear(crearProductoDTO);

            if (producto == null)
            {
                return null;
            }

            var productoDTO = ProductoDTO.ConvertirAProductoDTO(producto);

            return productoDTO;
        }

        public ProductoDTO Actualizar(int id, ActualizarProductoDTO actualizarProductoDTO)
        {
            // Implementar la lógica para actualizar un producto
            var producto = repositorioProducto.Actualizar(id, actualizarProductoDTO);

            var productoDTO = ProductoDTO.ConvertirAProductoDTO(producto);

            return productoDTO;
        }

        public List<ProductoDTO> Get()
        {
            // Obtener la lista de productos desde el repositorio
            var listaProductos = repositorioProducto.Get();
            var productoDTO = new List<ProductoDTO>();

            foreach (Producto producto in listaProductos)
            {
                var result = ProductoDTO.ConvertirAProductoDTO(producto);
                productoDTO.Add(result);
            }

            return productoDTO;
        }

        public ProductoDTO? GetById(int id)
        {
            var producto = repositorioProducto.GetById(id);

            var productoDTO = ProductoDTO.ConvertirAProductoDTO(producto);

            return productoDTO;
        }

        public void Borrar(int id)
        {
            repositorioProducto.Borrar(id);
        }   
    }
}
