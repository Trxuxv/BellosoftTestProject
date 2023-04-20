using Microsoft.AspNetCore.Mvc;

namespace TestWebProject.Controllers
{
    public class PrivacyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
