using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EntityDemo.Models;

namespace EntityDemo.Controllers
{
    public class HomeController : Controller
    {
       private MyContext _context;
       public HomeController(MyContext context)
       {
           _context = context;
       }
       [HttpGet("")]
       public ViewResult Index()
       {
           List<User> AllUsers = _context.Users.ToList();
           ViewBag.UserList = AllUsers;
           return View();
       }
       [HttpPost("create")]
       public IActionResult CreateUser(User newUser)
       {
           if(ModelState.IsValid)
           {
            _context.Add(newUser);
            _context.SaveChanges();
            return RedirectToAction("Index");
           }
           else
           {
               return View("Index");
           }
       }
    }
}
