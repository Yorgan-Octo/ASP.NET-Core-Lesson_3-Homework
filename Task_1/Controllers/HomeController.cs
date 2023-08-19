using Microsoft.AspNetCore.Mvc;

namespace Task_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Error(string? id)
        {
            return View(id as object);
        }

    }
}
