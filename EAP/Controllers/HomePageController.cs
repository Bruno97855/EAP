using Microsoft.AspNetCore.Mvc;

namespace EAP.Controller
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
