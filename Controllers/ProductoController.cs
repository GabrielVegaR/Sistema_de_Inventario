using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using Sistema_de_Inventario.Abstracciones.Servicios;
using Sistema_de_Inventario.DTOs.Producto;

namespace Sistema_de_Inventario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IServicioProducto servicioProducto;

        public ProductoController(IServicioProducto servicioProducto)
        {
            this.servicioProducto = servicioProducto;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listaProducto = servicioProducto.Get();
            return Ok(listaProducto);
        }

        [HttpPost]
        public IActionResult Crear(CrearProductoDTO crearProductoDTO)
        {
            var create = servicioProducto.Crear(crearProductoDTO);

            return Ok(create);
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, ActualizarProductoDTO actualizarProducto)
        {
            var update = servicioProducto.Actualizar(id, actualizarProducto);
            return Ok(update);
        }

        [HttpDelete("{id}")]
        public IActionResult Borrar(int id)
        {
            servicioProducto.Borrar(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var persona = servicioProducto.GetById(id);

            return Ok(persona);
        }
    }
}
