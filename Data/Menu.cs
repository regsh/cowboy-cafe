﻿/*
 * Menu.cs
 * Author: Regan Hale
 * Date: 4/17/20
 */
using System;
using System.Collections.Generic;

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

        public static string[] SodaFlavors
        {
            get => new string[]
            {
            "Cream Soda",
            "Orange Soda",
            "Sarsaparilla",
            "Birch Beer",
            "Root Beer"
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
            foreach (IOrderItem item in Entrees())
            {
                completeMenu.Add(item);
            }
            foreach (IOrderItem item in Sides())
            {
                completeMenu.Add(item);
            }
            foreach (IOrderItem item in Drinks())
            {
                completeMenu.Add(item);
            }
            return completeMenu;
        }

        public static IEnumerable<IOrderItem> CompleteSearch(IEnumerable<IOrderItem> items, string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (terms == null) return items;
            foreach (IOrderItem item in items)
            {
                if(item is Side side)
                {
                    if (side.SmallAvailable)
                    {
                        side.Size = Size.Small;
                        if (!side.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase)) side.SmallAvailable = false;
                    }
                    if (side.MediumAvailable)
                    {
                        side.Size = Size.Medium;
                        if (!side.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase)) side.MediumAvailable = false;
                    }
                    if (side.LargeAvailable)
                    {
                        side.Size = Size.Large;
                        if (!side.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase)) side.LargeAvailable = false;
                    }
                    if (side.InStock) results.Add(side);
                }

                else if (item is Drink drink)
                {
                    if (drink.SmallAvailable)
                    {
                        drink.Size = Size.Small;
                        if (!drink.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase)) drink.SmallAvailable = false;
                    }
                    if (drink.MediumAvailable)
                    {
                        drink.Size = Size.Medium;
                        if (!drink.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase)) drink.MediumAvailable = false;
                    }
                    if (drink.LargeAvailable)
                    {
                        drink.Size = Size.Large;
                        if (!drink.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase)) drink.LargeAvailable = false;
                    }
                    if (drink.InStock) results.Add(drink);
                }
                else if (item.Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
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
            if (calorieMin == null) calorieMin = 0;
            if (calorieMax == null) calorieMax = uint.MaxValue;
            foreach (IOrderItem item in items)
            {
                if (item is Side side)
                {
                    if (side.SmallAvailable)
                    {
                        side.Size = Size.Small;
                        if (side.Calories < calorieMin || item.Calories > calorieMax) side.SmallAvailable = false;
                    }
                    if (side.MediumAvailable)
                    {
                        side.Size = Size.Medium;
                        if (side.Calories < calorieMin || item.Calories > calorieMax) side.MediumAvailable = false;
                    }
                    if (side.LargeAvailable)
                    {
                        side.Size = Size.Large;
                        if (side.Calories < calorieMin || item.Calories > calorieMax) side.LargeAvailable = false;
                    }
                    results.Add(item);
                }
                if (item is Drink drink)
                {
                    if (drink.SmallAvailable)
                    {
                        drink.Size = Size.Small;
                        if (drink.Calories < calorieMin || item.Calories > calorieMax) drink.SmallAvailable = false;
                    }
                    if (drink.MediumAvailable)
                    {
                        drink.Size = Size.Medium;
                        if (drink.Calories < calorieMin || item.Calories > calorieMax) drink.MediumAvailable = false;
                    }
                    if (drink.LargeAvailable)
                    {
                        drink.Size = Size.Large;
                        if (drink.Calories < calorieMin || item.Calories > calorieMax) drink.LargeAvailable = false;
                    }
                    results.Add(item);
                }
                else if (item.Calories >= calorieMin && item.Calories <= calorieMax)
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

            if (priceMin == null) priceMin = 0;
            else if (priceMax == null) priceMax = double.MaxValue;
            
            foreach (IOrderItem item in items)
            {
                if (item is Side side)
                {
                    if (side.SmallAvailable)
                    {
                        side.Size = Size.Small;
                        if (side.Price < priceMin || item.Price > priceMax) side.SmallAvailable = false;
                    }
                    if (side.MediumAvailable)
                    {
                        side.Size = Size.Medium;
                        if (side.Price < priceMin || item.Price > priceMax) side.MediumAvailable = false;
                    }
                    if (side.LargeAvailable)
                    {
                        side.Size = Size.Large;
                        if (side.Price < priceMin || item.Price > priceMax) side.LargeAvailable = false;
                    }
                    results.Add(item);
                }
                if (item is Drink drink)
                {
                    if (drink.SmallAvailable)
                    {
                        drink.Size = Size.Small;
                        if (drink.Price < priceMin || item.Price > priceMax) drink.SmallAvailable = false;
                    }
                    if (drink.MediumAvailable)
                    {
                        drink.Size = Size.Medium;
                        if (drink.Price < priceMin || item.Price > priceMax) drink.MediumAvailable = false;
                    }
                    if (drink.LargeAvailable)
                    {
                        drink.Size = Size.Large;
                        if (drink.Price < priceMin || item.Price > priceMax) drink.LargeAvailable = false;
                    }
                    results.Add(item);
                }
                else if (item.Price >= priceMin && item.Price <= priceMax)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
