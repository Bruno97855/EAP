using Microsoft.AspNetCore.Mvc;

namespace EAP.Controllers.CriacaoPersonagem
{
    public class Passo3HABController : Controller
    {
        public IActionResult Index()
        {
            return View("../Pages/CriacaoPersonagem/Passo3HAB");
        }
    }
}
