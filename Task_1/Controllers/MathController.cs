using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using Task_1.Models;

namespace Task_1.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Add(int num1, int num2)
        {
            double sum = default;

            try
            {
                sum = ModeMath.Add(num1, num2);
            }
            catch (Exception ex)
            {
                return Redirect($"/Home/Error/{ex.Message}");
            }

            return View("Result", sum);
        }

        public IActionResult Sum(int num1, int num2)
        {
            double sum = default;

            try
            {
                sum = ModeMath.Sum(num1, num2);
            }
            catch (Exception ex)
            {
                return Redirect($"/Home/Error/{ex.Message}");
            }

            return View("Result", sum);
        }

        public IActionResult Mul(int num1, int num2)
        {
            double sum = default;

            try
            {
                sum = ModeMath.Mul(num1, num2);
            }
            catch (Exception ex)
            {
                return Redirect($"/Home/Error/{ex.Message}");
            }

            return View("Result", sum);
        }

        public IActionResult Div(int num1, int num2)
        {
            double sum = default;

            try
            {
                if (num1 == 0 || num2 == 0)
                    throw new Exception();

                sum = ModeMath.Div(num1, num2);
            }
            catch (Exception ex)
            {
                return Redirect($"/Home/Error/{ex.Message}");
            }

            return View("Result", sum);
        }

    }
}
