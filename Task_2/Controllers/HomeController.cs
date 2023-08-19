using Microsoft.AspNetCore.Mvc;

namespace Task_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //string ipAddress = HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.Ip = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.UserAgent = Request.Headers["User-Agent"];


            return View();
        }
    }
}
