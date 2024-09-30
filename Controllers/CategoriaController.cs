using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Inventario.Abstracciones.Servicios;
using Sistema_de_Inventario.DTOs.Categoria;

namespace Sistema_de_Inventario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly IServicioCategoria servicioCategoria;

        public CategoriaController(IServicioCategoria servicioCategoria)
        {
            this.servicioCategoria = servicioCategoria;
        }

        [HttpGet]
        public IActionResult index()
        {
            var listaCategoria = servicioCategoria.Get();
            return Ok(listaCategoria);
        }

        [HttpPost]
        public IActionResult Crear(CrearCategoriaDTO crearCategoriaDTO)
        {
            var create = servicioCategoria.Crear(crearCategoriaDTO);

            return Ok(create);
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, ActualizarCategoriaDTO actualizarCategoria)
        {
            var update = servicioCategoria.Actualizar(id, actualizarCategoria);
            return Ok(update);
        }

        [HttpDelete("{id}")]
        public IActionResult Borrar(int id)
        {
            servicioCategoria.Borrar(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var persona = servicioCategoria.GetById(id);

            return Ok(persona);
        }

    }
}
