using Microsoft.AspNetCore.Mvc;

namespace EAP.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View("../Pages/Index");
        }
    }
}
