/*
 * CowboyCoffee.cs
 * Author: Regan Hale
 * Purpose: Class to represent a Cowboy Coffee order at the Cowboy Cafe
 */
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents a cowboy coffee order at the cowboy cafe
    /// </summary>
    public class CowboyCoffee : Drink
    {
        public bool Decaf { get; set; } = false;
        /// <summary>
        /// Whether room should be left for cream when preparing order
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        
        /// <summary>
        /// The price of the coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small): return 0.60;
                    case (Size.Medium): return 1.10;
                    case (Size.Large): return 1.60;
                    default: throw new ArgumentException();
                }
            }
        }
        /// <summary>
        /// The caloric content of the coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small): return 3;
                    case (Size.Medium): return 5;
                    case (Size.Large): return 7;
                    default: throw new ArgumentException();
                }
            }
        }
        /// <summary>
        /// Special instructions for the preparation of the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");
                if (Decaf) instructions.Add("Decaf");
                return instructions;
            }
        }
    }
}
