using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CowboyCafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty (SupportsGet =true)]
        public string SearchTerms { get; set; }

        [BindProperty (SupportsGet =true)]
        public string[] ItemType { get; set; }

        [BindProperty (SupportsGet =true)]
        public uint? CalorieMin { get; set; }

        [BindProperty (SupportsGet =true)]
        public uint? CalorieMax { get; set; }

        [BindProperty(SupportsGet =true)]
        public double? PriceMin { get; set; }

        [BindProperty (SupportsGet =true)]
        public double? PriceMax { get; set; }
        
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            

        }
    }
}
