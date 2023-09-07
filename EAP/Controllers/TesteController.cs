using Microsoft.AspNetCore.Mvc;
using EAP.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EAP.Controllers.CriacaoPersonagem
{
    public class TesteController : Controller
    {
        public ActionResult Index()
        {
            var model = new TesteModel();

            ViewBag.ItemList = new List<SelectListItem>
                 {
                new SelectListItem { Value = "1", Text = "Item 1" },
                new SelectListItem { Value = "2", Text = "Item 2" },
                new SelectListItem { Value = "3", Text = "Item 3" },
            };

            return View(model);
        }
    }
}
