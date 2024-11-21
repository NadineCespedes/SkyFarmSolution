using Microsoft.AspNetCore.Mvc;
using SkyFarmApi.Dto;
using SkyFarmApi.entity;
using SkyFarmClasses.entidades;
using SkyFarmClasses.repositorios;
using System.Collections.Generic;

namespace SkyFarmApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {

        [HttpGet("/produto/listar")]
        [ProducesResponseType(200, Type = typeof(List<Produto>))]
        public IActionResult todos()
        {
            
            List < Produto >lista= new DtoProduto().listaProduto();
            return Ok(new JsonResult(lista));
        }
    }
}
