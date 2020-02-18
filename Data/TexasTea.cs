/*
 * TexasTea.cs
 * Author:Regan Hale
 * Class to represent the Texas Tea drink at the Cowboy Cafe
 */
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents an order of TexasTea
    /// </summary>
    public class TexasTea : Drink
    {
        /// <summary>
        /// Whether the tea has added sweetener
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// Whether the tea is served with a lemon wedge
        /// </summary>
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// Price of the tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small): return 1.00;
                    case (Size.Medium): return 1.50;
                    case (Size.Large): return 2.00;
                    default: throw new ArgumentException(); //should never happen, as size has a default value
                }
            }
        }
        /// <summary>
        /// Caloric content of the tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint kCals;
                switch (Size)
                {
                    case (Size.Small):
                        kCals = 10;
                        break;
                    case (Size.Medium):
                        kCals = 22;
                        break;
                    case (Size.Large):
                        kCals = 36;
                        break;
                    default: throw new ArgumentException();
                }
                if (!Sweet) kCals /= 2;
                return kCals;
            }
        }
        /// <summary>
        /// Special instructions for the preparation of the tea
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
        /// <summary>
        /// Returns a description of the drink including size as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return EnumHandler.SizeString(Size) + " Texas Tea";
            
        }


    }
}
