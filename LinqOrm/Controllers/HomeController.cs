using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LinqOrm.Models;
using System.Linq;

namespace LinqOrm.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            // Product[] myProducts = new Product[]
            // {
            //     new Product { Name = "Jeans", Category = "Clothing", Price = 24.7 },
            //     new Product { Name = "Socks", Category = "Clothing", Price = 8.12 },
            //     new Product { Name = "Scooter", Category = "Vehicle", Price = 99.99 },
            //     new Product { Name = "Skateboard", Category = "Vehicle", Price = 24.99 },
            //     new Product { Name = "Skirt", Category = "Clothing", Price = 17.5 }
            // };
            // Product[] sortedProducts = myProducts.OrderByDescending(prod => prod.Price).Where(prod => prod.Name.StartsWith("S")).ToArray();
            // ViewBag.Products = sortedProducts;
            // Product justJeans = myProducts.FirstOrDefault(prod => prod.Name == "Jeans");
            // ViewBag.JustJeans = justJeans;
            List<string> Food = new List<string>
            {
                "apple",
                "banana",
                "carrot",
                "fudge",
                "tomato"
            };

            List<string> Adjective = new List<string>
            {
            "tasty",
            "capital",
            "best",
            "typical",
            "flavorful",
            "toothsome",
            "fruity"
            };

            List<string> Alliterations = Food.Join(Adjective, foodItem => foodItem[0], adj => adj[0], (foodItem, adj) => {
                return adj + " " + foodItem;
            }).ToList();
            ViewBag.Allit = Alliterations;
            return View();
        }
    }
}
