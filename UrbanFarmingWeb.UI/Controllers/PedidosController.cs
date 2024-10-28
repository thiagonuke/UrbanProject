using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UrbanFarming.Domain.Classes;
using UrbanFarmingWeb.UI.Request;
using UrbanFarmingWeb.UI.Util;

namespace UrbanFarmingWeb.UI.Controllers
{
	public class PedidosController : Controller
	{
        private readonly RequestAPI _requestAPI;
        public PedidosController(RequestAPI requestAPI) { 
        
            _requestAPI = requestAPI;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.Get<User>("USER") != null)
            {
                ViewBag.Name = HttpContext.Session.Get<User>("USER").Nome;
            }

            var pedidos = _requestAPI.ListaPedidos().Result;


            return View();
        }

        [HttpPost]
        public IActionResult CadastrarPedidos([FromBody] Pedido pedido)
        {
            var aa = JsonConvert.SerializeObject(pedido);
            if (ModelState.IsValid)
            {
                var teste = _requestAPI.EfetuarCadastradoPedido(pedido).Result;

                return Ok("Pedido cadastrado com sucesso!");
            }
            return BadRequest("Erro ao cadastrar o pedido.");
        }
    }
}
