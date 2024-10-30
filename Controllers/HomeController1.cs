using Microsoft.AspNetCore.Mvc;

namespace WEBCOREBCC2024.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
