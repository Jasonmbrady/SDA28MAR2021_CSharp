using Microsoft.AspNetCore.Mvc;

namespace MvcIntro.Controllers
{
    public class HelloController : Controller
    {
        // [HttpGet]
        // [Route("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("pizza/{topping}")]
        public string Pizza(string topping)
        {
            return $"{topping} Pizza Time!";
        }

        [HttpGet("pizza/yuck")]
        public string PizzaYuck()
        {
            return "I hate pizza!";
        }
    }
}