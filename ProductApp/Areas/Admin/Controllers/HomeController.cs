using Microsoft.AspNetCore.Mvc;

namespace ProductApp.Areas.Admin.Controllers
{
    [Area("Admin")] 
    // iki homecontroller'i birbirinden ayirmak icin. program.cs mapcontrollerroute kismina bak. sil ve tekrar dene.
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
