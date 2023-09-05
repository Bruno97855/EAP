using Microsoft.AspNetCore.Mvc;

namespace EAP.Controllers.CriacaoPersonagem
{
    public class Passo1NRController : Controller
    {
        public IActionResult Index()
        {
            return View("../Pages/CriacaoPersonagem/Passo1NR");
        }
    }
}
