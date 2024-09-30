using Sistema_de_Inventario.Models;
using Sistema_de_Inventario.Abstracciones.Repositorios;
using Sistema_de_Inventario.DTOs.Proveedor;

namespace Sistema_de_Inventario.Implementaciones.Repositorios
{
    public class RepositorioProveedor : IRepositorioProveedor
    {
        private readonly InventorySystemContext _context;
        public RepositorioProveedor(InventorySystemContext context)
        {
            _context = context;
        }

        public Proveedor Actualizar(int id, ActualizarProveedorDTO actualizarProveedorDTO)
        {
            var proveedorActual = GetById(id);

            if (proveedorActual == null)
            {
                throw new Exception("Proveedor no Encontrado");
            }

            proveedorActual.Nombre = actualizarProveedorDTO.Nombre ?? actualizarProveedorDTO.Nombre;
            proveedorActual.Email = actualizarProveedorDTO.Email ?? actualizarProveedorDTO.Email;
            proveedorActual.CodigoArea = actualizarProveedorDTO.CodigoArea ?? actualizarProveedorDTO.CodigoArea;
            proveedorActual.CodigoPais = actualizarProveedorDTO.CodigoPais ?? actualizarProveedorDTO.CodigoPais;
            proveedorActual.Telefono = actualizarProveedorDTO.Telefono ?? actualizarProveedorDTO.Telefono;

            var result = _context.Update(proveedorActual);
            _context.SaveChanges();
            return result.Entity;
        }
        public Proveedor? Crear(CrearProveedorDTO crearProveedorDTO)
        {
            var proveedor = new Proveedor
            {
                Nombre = crearProveedorDTO.Nombre,
                Email = crearProveedorDTO.Email,
                CodigoArea = crearProveedorDTO.CodigoArea,
                CodigoPais = crearProveedorDTO.CodigoPais,
                Telefono = crearProveedorDTO.Telefono,
                FechaCreacion = DateTime.Now
            };

            var result = _context.Add(proveedor);
            _context.SaveChanges();

            return result.Entity;
        }
        public void Borrar(int id)
        {
            var borrar = GetById(id);

            if (borrar == null)
            {
                throw new Exception("Usuario no Encontrado");
            }

            _context.Proveedores.Remove(borrar);
            _context.SaveChanges();
        }

        public List<Proveedor> Get()
        {
            return [.. _context.Proveedores];
        }

        public Proveedor? GetById(int id)
        {
            return _context.Proveedores.Where(p => p.ProveedorId == id).FirstOrDefault();
        }
    }
}
