using Microsoft.AspNetCore.Mvc;

namespace MvcIntro.Controllers
{
    public class FirstController : Controller
    {
        [HttpGet("")]        
        public RedirectToActionResult Method()
        {
            return RedirectToAction("OtherMethod", "Food", new {Food = "sandwiches", Quantity = 3});
        }
        
        [HttpGet("test")]
        public ViewResult Test()
        {
            return View();
        }

        [HttpGet("{response}")]
        public IActionResult Depends(string response)
        {
            if(response == "redirect")
            {
                return RedirectToAction("Method");
            }
            else if(response == "json")
            {
                return Json(new {MyReponse = response});
            }
            return View();
        }
        // [HttpGet("other/{Food}/{Quantity}")]
        // public ViewResult OtherMethod(string Food, int Quantity)
        // {
        //     return View("Index");
        // }
    }
}