using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Task_5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
