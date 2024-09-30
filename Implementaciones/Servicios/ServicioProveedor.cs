using Sistema_de_Inventario.Abstracciones.Repositorios;
using Sistema_de_Inventario.Abstracciones.Servicios;
using Sistema_de_Inventario.DTOs.Proveedor;
using Sistema_de_Inventario.Models;

namespace Sistema_de_Inventario.Implementaciones.Servicios
{
    public class ServicioProveedor : IServicioProveedor
    {
        private readonly IRepositorioProveedor repositorioProveedor;

        public ServicioProveedor(IRepositorioProveedor repositorioProveedor)
        {
            this.repositorioProveedor = repositorioProveedor;
        }

        public ProveedorDTO? Crear(CrearProveedorDTO crearProveedorDTO)
        {
            var proveedor = repositorioProveedor.Crear(crearProveedorDTO);
            if (proveedor == null)
            {
                return null;
            }
            var proveedorDTO = ProveedorDTO.ConvertirAProveedorDTO(proveedor);
            return proveedorDTO;
        }

        public ProveedorDTO Actualizar(int id, ActualizarProveedorDTO actualizarProveedorDTO)
        {
            var proveedor = repositorioProveedor.Actualizar(id, actualizarProveedorDTO);
            var proveedorDTO = ProveedorDTO.ConvertirAProveedorDTO(proveedor);
            return proveedorDTO;
        }

        public void Borrar(int id)
        {
            repositorioProveedor.Borrar(id);
        }

        public List<ProveedorDTO> Get()
        {
            var listaProveedores = repositorioProveedor.Get();
            var proveedoresDTO = new List<ProveedorDTO>();

            foreach (Proveedor proveedor in listaProveedores)
            {
                var result = ProveedorDTO.ConvertirAProveedorDTO(proveedor);
                proveedoresDTO.Add(result);
            }

            return proveedoresDTO;
        }

        public ProveedorDTO? GetById(int id)
        {
            var proveedor = repositorioProveedor.GetById(id);
            var proveedorDTO = ProveedorDTO.ConvertirAProveedorDTO(proveedor);
            return proveedorDTO;
        }
    }
}
