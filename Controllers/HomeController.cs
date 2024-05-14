using Microsoft.AspNetCore.Mvc;

namespace RSOD.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
