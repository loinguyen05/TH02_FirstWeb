using Microsoft.AspNetCore.Mvc;

namespace SachOnline.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult NameList()
        {
            string? names = null;
            return View(names);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
