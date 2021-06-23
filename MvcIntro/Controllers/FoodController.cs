using Microsoft.AspNetCore.Mvc;

namespace MvcIntro.Controllers
{
    public class FoodController : Controller
    {
        [HttpGet("other/{Food}/{Quantity}")]
        public ViewResult OtherMethod(string Food, int Quantity)
        {
            // Keeping params in ViewBag to render later
            ViewBag.Food = Food;
            ViewBag.Quantity = Quantity;
            return View("Index");
        }
    }
}