using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tutorialdotnetcore.Models;

namespace tutorialdotnetcore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["mensaje"] = "Hola Mundo!";
            return View();
        }

        public IActionResult Saludos()
        {
            ViewData["saludo"] = "Hola a Todos";
            return View();
        }

        public IActionResult Perfil()
        {
            var miUsuario = new Usuario
            {
                Nombre = "Roger Gomez",
                Correo = "rogergomezs2003@gmail.com"
            };

            return View(miUsuario);
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
