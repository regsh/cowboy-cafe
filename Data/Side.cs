/*
 * Size.cs
 * Author:Nathan Bean
 * Edited by: Regan Hale
 * Purpose: Size base class from which sides at cowboy cafe are derived
 */

using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side:IOrderItem
    {
        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        //can i just make this null and do a null check later
        //no sides have special instructions
        public List<string> SpecialInstructions { get; set; }
    }
}
