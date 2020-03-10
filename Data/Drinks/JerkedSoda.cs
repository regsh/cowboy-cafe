/*
 * JerkedSoda.cs
 * Author:Regan Hale
 * Class to represent a Jerked Soda at the Cowboy Cafe
 */
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents an order of Jerked Soda
    /// </summary>
    public class JerkedSoda : Drink
    {
        private SodaFlavor flavor = SodaFlavor.CreamSoda;
        /// <summary>
        /// The flavor of the soda order
        /// </summary>
        public SodaFlavor Flavor
        {
            get => flavor;
            set
            {
                flavor = value;
                NotifyPropertyChanged("Flavor");
                NotifyPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Price of the soda
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small): return 1.59;
                    case (Size.Medium): return 2.10;
                    case (Size.Large): return 2.59;
                    default: throw new ArgumentException(); //should never happen, as size has a default value
                }
            }
        }
        /// <summary>
        /// Caloric content of the soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small): return 110;
                    case (Size.Medium): return 146;
                    case (Size.Large): return 198;
                    default: throw new ArgumentException();
                }
            }
        }
        /// <summary>
        /// Special instructions for the preparation of the soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");
                return instructions;
            }
        }

        /// <summary>
        /// Property holding the name for display in the order summary
        /// </summary>
        public override string Name => ToString();

        /// <summary>
        /// Returns the size and flavor and name of the jerked soda as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = Size.ToString();
            switch (Flavor)
            {
                case (SodaFlavor.CreamSoda):
                    result += " Cream Soda";
                    break;
                case (SodaFlavor.BirchBeer):
                    result += " Birch Beer";
                    break;
                case (SodaFlavor.OrangeSoda):
                    result += " Orange Soda";
                    break;
                case (SodaFlavor.RootBeer):
                    result += " Root Beer";
                    break;
                case (SodaFlavor.Sarsparilla):
                    result += " Sarsparilla";
                    break;
                default: throw new ArgumentException();
            }
            result += " Jerked Soda";
            return result;
        }
    }
}
