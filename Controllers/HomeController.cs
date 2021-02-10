using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Top5Restaurants.Models;

namespace Top5Restaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //create a list and store the contents of the restaurant array
            List<string> restList = new List<string>();

            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                string? favDish = r.RestFavDish ?? "It's all tasty!";

                restList.Add($"{r.RestName} <br> Favorite Dish: {favDish} <br> Address: {r.RestAddress} <br> Phone Number: {r.RestNumber} <br>  Website: {r.RestWebsite} <br><br>");
            }

            return View(restList);
        }

        public IActionResult Suggestions()
        {
            return View(TempStorage.Suggestions);
        }

        public IActionResult Confirmation ()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddSuggestion()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSuggestion(Suggestion suggestion)
        {
            //Make sure that the inputs are valid
            if(ModelState.IsValid){
                TempStorage.AddSuggestion(suggestion);
                return View("Confirmation", suggestion);
            }
            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
