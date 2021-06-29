using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace DachiDemo.Controllers
{
    public class HomeController : Controller
    {
      int Fullness = 20;
      int Happiness = 20;
      int Energy = 50;
      int Meals = 3;

      [HttpGet("")]
      public ViewResult Index()
      {
          if (HttpContext.Session.GetInt32("Fullness") == null)
          {
              HttpContext.Session.SetInt32("Fullness", Fullness);
              HttpContext.Session.SetInt32("Happiness", Happiness);
              HttpContext.Session.SetInt32("Energy", Energy);
              HttpContext.Session.SetInt32("Meals", Meals);
          }
            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
          return View();
      }

      [HttpGet("restart")]
      public RedirectToActionResult Restart()
      {
          HttpContext.Session.Clear();
          return RedirectToAction("Index");
      }

      [HttpGet("feed")]
      public RedirectToActionResult Feed()
      {
          if (HttpContext.Session.GetInt32("Meals") >= 1){
              Random rand = new Random();
              int? MealCount = HttpContext.Session.GetInt32("Meals");
              int? FullCount = HttpContext.Session.GetInt32("Fullness");
              MealCount--;
              FullCount += rand.Next(5, 11);
              HttpContext.Session.SetInt32("Meals", (int)MealCount);
              HttpContext.Session.SetInt32("Fullness", (int)FullCount);
          }
          return RedirectToAction("Index");
      }

      [HttpGet("play")]
      public RedirectToActionResult Play()
      {
          Random rand = new Random();
          int? EnergyCount = HttpContext.Session.GetInt32("Energy");
          int? HappyCount =  HttpContext.Session.GetInt32("Happiness");
          EnergyCount -= 5;
          HappyCount += rand.Next(5,11);
          if (EnergyCount <= 0){
              return RedirectToAction("Lose");
          }
          else if (HttpContext.Session.GetInt32("Fullness") > 100 && HappyCount > 100 && EnergyCount > 100)
          {
              return RedirectToAction("Win");
          }
          else {
            HttpContext.Session.SetInt32("Energy", (int)EnergyCount);
            HttpContext.Session.SetInt32("Happiness", (int)HappyCount);
            return RedirectToAction("Index");
          }
      }
      [HttpGet("win")]
      public ViewResult Win()
      {
          return View();
      }

      [HttpGet("lose")]
      public ViewResult Lose()
      {
          return View();
      }
    }
}
