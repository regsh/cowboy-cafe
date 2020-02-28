/*
 * Drink.cs
 * Author:Regan Hale
 * Purpose: Base class for foundation of drink orders at the cowboy cafe
 */
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    ///Abstract class to represent a generic drink at the Cowboy Cafe
    /// </summary>
    public abstract class Drink:IOrderItem
    {
        /// <summary>
        /// Represents the size of the drink, default of small
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Represents the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Represents the caloric content of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Whether the given drink contains ice
        /// </summary>
        public virtual bool Ice { get; set; } = true;
        /// <summary>
        /// Special instructions for preparing the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}
