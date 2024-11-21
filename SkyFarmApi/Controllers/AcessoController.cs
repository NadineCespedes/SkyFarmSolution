using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SkyFarmApi.Dto;
using SkyFarmClasses.entidades;
using SkyFarmClasses.repositorios;

namespace SkyFarmApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AcessoController : ControllerBase
    {

        [HttpGet("/api")]
        [ProducesResponseType(200, Type = typeof(String))]
        public String okApi()
        {
            return "ok";
        }

        [HttpPost("/autenticar")]
        [ProducesResponseType(200, Type = typeof(EntidadeAcessoSistema))]
        [ProducesResponseType(404)]
        public IActionResult autenticarAcesso(DtoAcessoSistema acesso)
        {
            EntidadeAcessoSistema usuarioLogado = new EntidadeAcessoSistema();
            usuarioLogado.Login = acesso.Login;
            usuarioLogado.Email = acesso.Login;
            usuarioLogado.Senha = acesso.senha;
            usuarioLogado =new RepositorioAcessoSistema().carregarUsuario(usuarioLogado);
            if (usuarioLogado == null) return NotFound("Usuario não encontrado");
            return Ok(new JsonResult(usuarioLogado));
        }
    }
}
