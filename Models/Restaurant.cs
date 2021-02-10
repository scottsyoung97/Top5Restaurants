using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Top5Restaurants.Models
{
    public class Restaurant
    {

        public Restaurant(int rank)
        {
            RestRanking = rank;
        }

        [Required]
        public int RestRanking { get; }
        [Required]
        public string RestName { get; set; }
        [Required]
        public string RestFavDish { get; set; }
        public string RestAddress { get; set; }

        //Make Sure Phone Number has a valid input
        [RegularExpression(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$", ErrorMessage = "Please enter a valid phone number")]
        public string RestNumber { get; set; }
        public string RestWebsite { get; set; } = "Coming Soon";
        //Create Restaurants and store them within an array to pass to home controller
        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                RestName = "Mcdonalds",
                RestFavDish = "Hot N' Spicy McChicken",
                RestAddress = "123 Cougar Way",
                RestNumber = "801-999-8888",
                RestWebsite = "mcdonalds.com"
            };

            Restaurant r2 = new Restaurant(2)
            {
                RestName = "Wendys",
                RestFavDish = "Baconator",
                RestAddress = "456 BYU Avenue",
                RestNumber = "801-777-8888",
                RestWebsite = "wendys.com"
            };

            Restaurant r3 = new Restaurant(3)
            {
                RestName = "In N' Out Burger",
                RestFavDish = "Double Double",
                RestAddress = "789 Marriott Boulevard",
                RestNumber = "801-111-4444",
                RestWebsite = "innout.com"
            };

            Restaurant r4 = new Restaurant(4)
            {
                RestName = "Maria Bonitas",
                RestFavDish = "Carne Asada",
                RestAddress = "1011 Hilton Highway",
                RestNumber = "801-123-4567",
            };

            Restaurant r5 = new Restaurant(5)
            {
                RestName = "Panda Express",
                RestAddress = "1213 Spencer Circle",
                RestNumber = "801-765-4321",
                RestWebsite = "pandaexpress.com"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
