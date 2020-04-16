/*
 * Menu.cs
 * Author: Regan Hale
 * Date: 4/17/20
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Static class for use by website in representing CowboyCafe menu items
    /// </summary>
    public static class Menu
    {
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
    }
}
