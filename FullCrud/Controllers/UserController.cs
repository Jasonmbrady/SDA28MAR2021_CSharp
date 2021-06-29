using System;
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
        [HttpPost("Update/{id}")]
        public IActionResult Update(User updatedUser, int id)
        {
            User RetrievedUser = DbContext.Users.FirstOrDefault(u => u.UserId == id);
            if (ModelState.IsValid)
            {
                RetrievedUser.FirstName = updatedUser.FirstName;
                RetrievedUser.UpdatedAt = DateTime.Now;
                DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else 
            {
                return View("Detail", RetrievedUser);
            }
        }
        [HttpGet("delete/{id}")]
        public RedirectToActionResult Delete(int id)
        {
            User DelUser = DbContext.Users.SingleOrDefault(u => u.UserId == id);
            DbContext.Users.Remove(DelUser);
            DbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}