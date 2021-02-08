using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Top5Restaurants.Models
{
    public class TempStorage
    {
        private static List<Suggestion> suggestions = new List<Suggestion>();

        public static IEnumerable<Suggestion> Suggestions => suggestions;

        public static void AddSuggestion(Suggestion suggestion)
        {
            suggestions.Add(suggestion);
        }
    }
}
