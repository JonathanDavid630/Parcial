using Parcial.Bussiness;
using Microsoft.AspNetCore.Mvc;
using Parcial.Models;
using System.Diagnostics;

namespace Parcial.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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

        public IActionResult Multiplo(Multiplo multiplo)
        {     
            
            if (ModelState.IsValid && multiplo.Monto % 5 == 0)
            {             
                    //objeto de negocio
                    MultiploRetiro op = new MultiploRetiro();
                    double resultado = op.RetiroMultiplo(multiplo);
                    return View("Exito");
            }
            else
            {                
                return View("Error");
            }
        }

    }
}