using Microsoft.AspNetCore.Mvc;
using Projeto_ComBancoDeDados.Models;
using System.Diagnostics;

namespace Projeto_ComBancoDeDados.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Indelitrx()
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
    }
}
