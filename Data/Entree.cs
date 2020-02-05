/*Entree.cs
 * Author: Regan Hale
 * 2/5/2020
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Base class to represent an entree menu item at the cowboy cafe
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// Gets the price of an entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the caloric content of an entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Holds instructions for the creation of an entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
