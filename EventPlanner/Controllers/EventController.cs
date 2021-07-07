using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EventPlanner.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

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
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetInt32("uid") != null)
            {
                List<Event> allEvents = _context.Events
                .Include( e => e.Attendees)
                .ThenInclude( a => a.User)
                .ToList();
                return View("Dashboard", allEvents);
            }
            else
            {
                return RedirectToAction("NotLoggedIn");
            }
        }
        [HttpGet("not_logged_in")]
        public ViewResult NotLoggedIn()
        {
            return View("LogError");
        }

        [HttpGet("logout")]
        public RedirectToActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "User");
        }
        [HttpGet("event/new")]
        public ViewResult NewEvent()
        {
            return View();
        }
        
        [HttpPost("event/process")]
        public IActionResult ProcessNewEvent(Event newEvent)
        {
            if (ModelState.IsValid)
            {
                if (newEvent.Date < DateTime.Now)
                {
                    ModelState.AddModelError("Date", "Event must be in the future");
                    return View("NewEvent");
                }
                else
                {
                    newEvent.UserId = (int)HttpContext.Session.GetInt32("uid");
                    _context.Events.Add(newEvent);
                    _context.SaveChanges();
                    return RedirectToAction("Dashboard");
                }
            }
            else 
            {
                return View("NewEvent");
            }
        }
    }
}