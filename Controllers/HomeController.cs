using Microsoft.AspNetCore.Mvc;

namespace TestWebProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
