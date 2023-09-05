using Microsoft.AspNetCore.Mvc;

namespace EAP.Controllers.CriacaoPersonagem
{
    public class Passo2ATRIBController : Controller
    {
        public IActionResult Index()
        {
            return View("../CriacaoPersonagem/Passo2ATRIB");
        }
    }
}
