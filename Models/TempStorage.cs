using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Top5Restaurants.Models
{
    public class TempStorage
    {
        //create list to store suggestions in
        private static List<Suggestion> suggestions = new List<Suggestion>();

        //create ienumerable to iterate through it
        public static IEnumerable<Suggestion> Suggestions => suggestions;

        //add suggestions to list
        public static void AddSuggestion(Suggestion suggestion)
        {
            suggestions.Add(suggestion);
        }
    }
}
