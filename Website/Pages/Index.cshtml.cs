using CowboyCafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public string SearchTerms { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string[] ItemType { get; set; }

        [BindProperty(SupportsGet =true)]
        public uint? CalorieMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public uint? CalorieMax { get; set; }

        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }

        public IEnumerable<IOrderItem> Entrees { get; protected set; }

        public IEnumerable<IOrderItem> Sides { get; protected set; }

        public IEnumerable<IOrderItem> Drinks { get; protected set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if(ItemType.Contains("Entrees") || ItemType.Count() == 0)
            {
                Entrees = Menu.Entrees();
                if(SearchTerms != null)
                {
                    Entrees = Entrees.Where(entree =>
                        entree.Name.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase)
                        );
                }
                if(!(CalorieMin == null && CalorieMax == null))
                {
                    if (CalorieMax == null)
                    {
                        Entrees = Entrees.Where(entree =>
                            entree.Calories >= CalorieMin);
                    }
                    else if (CalorieMin == null)
                    {
                        Entrees = Entrees.Where(entree =>
                            entree.Calories <= CalorieMax);
                    }
                    else
                    {
                        Entrees = Entrees.Where(entree =>
                            entree.Calories >= CalorieMin &&
                            entree.Calories <= CalorieMax);
                    }
                }
                if (!(PriceMin == null && PriceMax == null))
                {
                    if (PriceMax == null)
                    {
                        Entrees = Entrees.Where(entree =>
                            entree.Price >= PriceMin);
                    }
                    else if (PriceMin == null)
                    {
                        Entrees = Entrees.Where(entree =>
                            entree.Price <= PriceMax);
                    }
                    else
                    {
                        Entrees = Entrees.Where(entree =>
                            entree.Price >= PriceMin &&
                            entree.Price <= PriceMax);
                    }
                }
                /*
                Entrees = Menu.CompleteSearch(Entrees, SearchTerms);
                Entrees = Menu.FilterByCalories(Entrees, CalorieMin, CalorieMax);
                Entrees = Menu.FilterByPrice(Entrees, PriceMin, PriceMax);
                */
            }
            if (ItemType.Contains("Sides") || ItemType.Count() == 0)
            {
                Sides = Menu.CompleteSearch(Menu.Sides(), SearchTerms);
                Sides = Menu.FilterByCalories(Sides, CalorieMin, CalorieMax);
                Sides = Menu.FilterByPrice(Sides, PriceMin, PriceMax);
            }

            if (ItemType.Contains("Drinks") || ItemType.Count() == 0)
            {
                Drinks = Menu.CompleteSearch(Menu.Drinks(), SearchTerms);
                Drinks = Menu.FilterByCalories(Drinks, CalorieMin, CalorieMax);
                Drinks = Menu.FilterByPrice(Drinks, PriceMin, PriceMax);
            }
        }
    }
}
