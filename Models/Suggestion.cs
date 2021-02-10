using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Top5Restaurants.Models
{
    public class Suggestion
    {
        public string Name { get; set; }
        public string RestName { get; set;}
        public string FavDish { get; set; }

        //Make sure that the phone number has a valid format
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Please enter a valid phone number")]
        public string Number { get; set; }

    }
}
