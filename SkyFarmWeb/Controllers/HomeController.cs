using Microsoft.AspNetCore.Mvc;
using SkyFarmWeb.Dto;
using SkyFarmWeb.Models;
using System.Diagnostics;

namespace SkyFarmWeb.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet("id")]
        [ProducesResponseType(200, Type=typeof(Cliente))]
        public IActionResult bili(int id) {
            
            Cliente c = new Cliente();

            return Ok(c.dtoId(id));
        }
    }
}
