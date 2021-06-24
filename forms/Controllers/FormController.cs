using Microsoft.AspNetCore.Mvc;

namespace forms.Controllers
{
    public class FormController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
    
    }
}