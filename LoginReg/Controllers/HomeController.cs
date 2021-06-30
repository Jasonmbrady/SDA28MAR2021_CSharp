using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LoginReg.Models;

namespace LoginReg.Controllers
{
    public class HomeController : Controller
    {
        private LogRegContext DbContext;
        public HomeController(LogRegContext context)
        {
            DbContext = context;
        }

        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(DbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "That Email is already in use!");
                    return View("Index");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    DbContext.Add(newUser);
                    DbContext.SaveChanges();
                    return RedirectToAction("AllUsers");
                }
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("allusers")]
        public ViewResult AllUsers()
        {
            if (HttpContext.Session.GetInt32("LoggedUser") != null)
            {
                ViewBag.AllUsers = DbContext.Users.ToList();
                return View();
            }
            else
            {
                ViewBag.Error = "You must be logged in to do that!";
                return View("Index");
            }
        }

        [HttpGet("login")]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost("loginuser")]
        public IActionResult LoginUser(LoginUser thisUser)
        {
            if(ModelState.IsValid)
            {
                User loginUser = DbContext.Users.FirstOrDefault(u => u.Email == thisUser.Email);
                if(loginUser == null){
                    ModelState.AddModelError("Email", "Invalid login credentials");
                    return View("Login");
                }
                else
                {
                    PasswordHasher<LoginUser> Hasher = new PasswordHasher<LoginUser>();
                    var result = Hasher.VerifyHashedPassword(thisUser, loginUser.Password, thisUser.Password);
                    if (result == 0)
                    {
                        ModelState.AddModelError("Email", "Invalid login credentials");
                        return View("Login");
                    }
                    HttpContext.Session.SetInt32("LoggedUser", loginUser.UserId);
                    return RedirectToAction("AllUsers");
                }
            }
            else
            {
                return View("Login");
            }
        }
    }
}
