/*
 * Menu.cs
 * Author: Regan Hale
 * Date: 4/17/20
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Static class for use by website in representing CowboyCafe menu items
    /// </summary>
    public static class Menu
    {
        public static string[] MenuItemTypes
        {
            get => new string[]
            {
            "Entrees",
            "Sides",
            "Drinks"
            };
        }

        /// <summary>
        /// Returns IEnumerable containing instance of all CowboyCafe entrees
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new AngryChicken());
            entrees.Add(new CowpokeChili());
            entrees.Add(new DakotaDoubleBurger());
            entrees.Add(new PecosPulledPork());
            entrees.Add(new RustlersRibs());
            entrees.Add(new TexasTripleBurger());
            entrees.Add(new Trailburger());
            return entrees;
        }
        /// <summary>
        /// Returns IEnumerable containing instance of all CowboyCafe sides
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            sides.Add(new BakedBeans());
            sides.Add(new ChiliCheeseFries());
            sides.Add(new CornDodgers());
            sides.Add(new PanDeCampo());
            return sides;
        }
        /// <summary>
        /// Returns IEnumerable containing instance of all CowboyCafe drinks
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            drinks.Add(new CowboyCoffee());
            drinks.Add(new JerkedSoda());
            drinks.Add(new TexasTea());
            drinks.Add(new Water());
            return drinks;
        }
        /// <summary>
        /// Returns IEnumerable containing instance of all CowboyCafe menu items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> completeMenu = new List<IOrderItem>();
            foreach(IOrderItem item in Entrees())
            {
                completeMenu.Add(item);
            }
            foreach(IOrderItem item in Sides())
            {
                completeMenu.Add(item);
            }
            foreach(IOrderItem item in Drinks())
            {
                completeMenu.Add(item);
            }
            return completeMenu;
        }

        public static IEnumerable<IOrderItem> CompleteSearch(IEnumerable<IOrderItem> items, string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (terms == null) return CompleteMenu();
            foreach(IOrderItem item in CompleteMenu())
            {
                if(item.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, uint? calorieMin, uint? calorieMax)
        {
            if (calorieMin == null && calorieMax == null) return items;
            var results = new List<IOrderItem>();
            if(calorieMin == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Calories <= calorieMax) results.Add(item);
                }
                return results;
            }

            if(calorieMax == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Calories >= calorieMin) results.Add(item);
                }
                return results;
            }

            foreach(IOrderItem item in items)
            {
                if(item.Calories >= calorieMin && item.Calories <= calorieMax)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? priceMin, double? priceMax)
        {
            if (priceMin == null && priceMax == null) return items;
            var results = new List<IOrderItem>();
            if (priceMin == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= priceMax) results.Add(item);
                }
            }
            else if (priceMax == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= priceMin) results.Add(item);
                }
            }
            else foreach (IOrderItem item in items)
            {
                if (item.Calories >= priceMin && item.Calories <= priceMax)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
