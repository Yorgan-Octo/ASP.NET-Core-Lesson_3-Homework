using Microsoft.AspNetCore.Mvc;
using Task_5.Models;

namespace Task_5.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {

            List<Item> ListIt = new List<Item>()
                 {
                new Item(1,"Телефон", 2467),
                new Item(2,"Камера", 5678),
                new Item(3,"Штатив", 245),
                new Item(4,"Кран", 8948),
                new Item(5,"Микшер", 2324),

                 };

            ViewBag.ItemCollection = ListIt;

            return View();
        }


        public IActionResult Index2()
        {

            List<Item> ListIt = new List<Item>()
                 {
                new Item(1,"Телефон", 2467),
                new Item(2,"Камера", 5678),
                new Item(3,"Штатив", 245),
                new Item(4,"Кран", 8948),
                new Item(5,"Микшер", 2324),

                 };

            return View(ListIt);
        }

    }
}


