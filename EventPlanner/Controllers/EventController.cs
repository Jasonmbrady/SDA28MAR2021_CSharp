using Microsoft.AspNetCore.Mvc;
using EventPlanner.Models;
using System.Linq;

namespace EventPlanner.Controllers
{
    public class EventController : Controller
    {
        private MyContext _context;
        public EventController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("dashboard")]
        public ViewResult Dashboard()
        {
            return View();
        }
    }
}