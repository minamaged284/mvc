using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUS() { return View(); }
        public IActionResult Privacy() { return View(); }
       public  IActionResult ContactUs() { return View(); }
    }
}
