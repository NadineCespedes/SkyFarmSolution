using Microsoft.AspNetCore.Mvc;
using SkyFarmApi.Dto;
using System.Text.Json.Serialization;

namespace SkyFarmApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        [HttpPost(Name = "PostClienteCadastro")]
        [ProducesResponseType(200, Type = typeof(DtoClienteCadastro))]
      
        public JsonResult cadastro(DtoClienteCadastro cadastro)
        {
            return new JsonResult(cadastro);
        }

    }
}
