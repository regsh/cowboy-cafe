/*
 * Water.cs
 * Author:Regan Hale
 * Public class to represent an order of Water at the Cowboy Cafe
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to represent an order of water
    /// </summary>
    class Water : Drink
    {
        public override double Price => 0.12;

        public override uint Calories => 0;

        public bool Lemon { get; set; } = false;

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
