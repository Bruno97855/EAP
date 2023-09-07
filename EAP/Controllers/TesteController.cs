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
                new SelectListItem { Value = "1", Text = "Texto Grande 111 222 333 444 555 666 777 888 999 111" },
                new SelectListItem { Value = "2", Text = "Texto Médio 11 22 33 44 55" },
                new SelectListItem { Value = "3", Text = "texto pequeno" },
            };

            return View(model);
        }
    }
}
