using System.Linq;
using FullCrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace FullCrud.Controllers
{
    public class UserController : Controller
    {
        private FullCrudContext DbContext;
        public UserController(FullCrudContext context)
        {
            DbContext = context;
        }
        [HttpGet("")]
        public ViewResult Index()
        {
            ViewBag.AllUnicorns = DbContext.Users.ToList();
            return View();
        }

        [HttpPost("Create")]
        public IActionResult Create(User newUser)
        {
            if(ModelState.IsValid)
            {
                DbContext.Add(newUser);
                DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.AllUnicorns = DbContext.Users.ToList();
                return View("Index");
            }
        }
        [HttpGet("{id}")]
        public ViewResult Detail(int id)
        {
            User thisUser = DbContext.Users.FirstOrDefault(user => user.UserId == id);
            return View("Detail", thisUser);
        }
    }
}