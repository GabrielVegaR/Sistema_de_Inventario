using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Inventario.Abstracciones.Servicios;
using Sistema_de_Inventario.DTOs.Pedido;

namespace Sistema_de_Inventario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IServicioPedido servicioPedido;

        public PedidoController(IServicioPedido servicioPedido)
        {
            this.servicioPedido = servicioPedido;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listaPedido = servicioPedido.Get();

            return Ok(listaPedido);
        }

        [HttpPost]
        public IActionResult Crear(CrearPedidoDTO pedido)
        {
            var create = servicioPedido.Crear(pedido);

            return Ok(create);
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, ActualizarPedidoDTO actualizarPedido)
        {
            var update = servicioPedido.Actualizar(id, actualizarPedido);
            return Ok(update);
        }

        [HttpDelete("{id}")]
        public IActionResult Borrar(int id)
        {
            servicioPedido.Borrar(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var persona = servicioPedido.GetById(id);

            return Ok(persona);
        }


    }
}
