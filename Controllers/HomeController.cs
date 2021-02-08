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

            List<string> restList = new List<string>();

            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                restList.Add($"{r.RestName} Favorite Dish: {r.RestFavDish} Address: {r.RestAddress} Phone Number: {r.RestNumber} Website: {r.RestWebsite}");
            }

            return View(restList);
        }

        public IActionResult Privacy()
        {
            return View(TempStorage.Suggestions);
        }

        public IActionResult Confirmation ()
        {
            return View();
        }

        [HttpGet]
        public IActionResult addsuggest()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addsuggest(Suggestion suggestion)
        {
            TempStorage.AddSuggestion(suggestion);
            return View("Confirmation", suggestion);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
