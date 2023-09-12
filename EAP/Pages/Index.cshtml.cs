using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EAP.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string SiteVersion { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            SiteVersion = "v1.0.0"; // Defina a versão do site aqui
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}