using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_4.Models;

namespace Task_4.Controllers
{
    public class JsonController : Controller
    {

        CliensListcs cList = new CliensListcs();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ClientInfo()
        {


            return Json(cList.clients);
        }

        public IActionResult ClientInfo2()
        {
            return Json(cList.clients);
        }
    }
}

