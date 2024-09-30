using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Inventario.Abstracciones.Servicios;
using Sistema_de_Inventario.DTOs.Producto;
using Sistema_de_Inventario.DTOs.Proveedor;
using Sistema_de_Inventario.Implementaciones.Servicios;

namespace Sistema_de_Inventario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        private readonly IServicioProveedor servicioProveedor;

        public ProveedorController(IServicioProveedor servicioProveedor)
        {
            this.servicioProveedor = servicioProveedor;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var proveedores = servicioProveedor.Get();
            return Ok(proveedores);
        }

        [HttpPost]
        public IActionResult Crear(CrearProveedorDTO crearProveedorDTO)
        {
            var create = servicioProveedor.Crear(crearProveedorDTO);

            return Ok(create);
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, ActualizarProveedorDTO actualizarProveedor)
        {
            var update = servicioProveedor.Actualizar(id, actualizarProveedor);
            return Ok(update);
        }

        [HttpDelete("{id}")]
        public IActionResult Borrar(int id)
        {
            servicioProveedor.Borrar(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var persona = servicioProveedor.GetById(id);

            return Ok(persona);
        }
    }
}
