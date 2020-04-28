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
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }

        public string[] ItemType { get; set; } = new string[3] { "Entrees", "Sides", "Drinks" };

        [BindProperty(SupportsGet = true)]
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
            ItemType = Request.Query[]
            if (ItemType.Contains("Entrees"))
            {
                Entrees = Menu.CompleteSearch(Menu.Entrees(), SearchTerms);
                Menu.FilterByCalories(Entrees, CalorieMin, CalorieMax);
                Menu.FilterByPrice(Entrees, PriceMin, PriceMax);
            }
            if (ItemType.Contains("Sides"))
            {
                Sides = Menu.CompleteSearch(Menu.Sides(), SearchTerms);
                Menu.FilterByCalories(Sides, CalorieMin, CalorieMax);
                Menu.FilterByPrice(Sides, PriceMin, PriceMax);
            }

            if (ItemType.Contains("Drinks"))
            {
                Drinks = Menu.CompleteSearch(Menu.Drinks(), SearchTerms);
                Menu.FilterByCalories(Drinks, CalorieMin, CalorieMax);
                Menu.FilterByPrice(Drinks, PriceMin, PriceMax);
            }
        }
    }
}
