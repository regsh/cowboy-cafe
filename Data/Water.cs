/*
 * Water.cs
 * Author:Regan Hale
 * Public class to represent an order of Water at the Cowboy Cafe
 */
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to represent an order of water
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Price of the water
        /// </summary>
        public override double Price => 0.12;

        /// <summary>
        /// Caloric content of the water
        /// </summary>
        public override uint Calories => 0;

        /// <summary>
        /// If the water is served with a lemon
        /// </summary>
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// Special instructions for preparing an order of water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");
                return instructions;
            }

        }
    }
}
