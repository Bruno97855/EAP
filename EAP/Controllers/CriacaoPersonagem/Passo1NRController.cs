using Microsoft.AspNetCore.Mvc;

namespace EAP.Controllers.CriacaoPersonagem
{
    public class Passo1NRController : Controller
    {
        public IActionResult Index()
        {
            return View("../CriacaoPersonagem/Passo1NR");
        }
    }
}
