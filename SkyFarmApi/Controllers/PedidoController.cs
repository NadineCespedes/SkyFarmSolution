using Microsoft.AspNetCore.Mvc;
using SkyFarmApi.Dto;
using SkyFarmApi.response;
using SkyFarmClasses;
using SkyFarmClasses.repositorios;

namespace SkyFarmApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {

        [HttpPost("/pedido")]
        [ProducesResponseType(200, Type = typeof(ResponsePedido))]

        public JsonResult efeturarCompra(DtoPedidoCompra pedido)
        {
            RegistrarPedido registrarPedido = new RegistrarPedido();
            registrarPedido.produtos(pedido.convertProdutoEntidade());
            registrarPedido.usuario(pedido.UsuarioLogado);
            registrarPedido.registrar();
            ResponsePedido response = new ResponsePedido();
            return new JsonResult(response);
        }
    }
}
