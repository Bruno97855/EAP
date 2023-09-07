using Microsoft.AspNetCore.Mvc.Rendering;

namespace EAP.Models
{
    public class TesteModel
    {
        public string? TextBox { get; set; }
        public List<SelectListItem> DropDownList { get; set; }
    }
}
