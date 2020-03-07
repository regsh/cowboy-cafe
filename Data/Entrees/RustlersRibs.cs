/*
 * RustlersRibs.cs
 * Author:Regan Hale
 * Purpose: represent the rustlers ribs entree at cowboy cafe
 */
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// The price of the ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }
        /// <summary>
        /// Calorie content of the ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }
        /// <summary>
        /// Special instructions for making the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }
        /// <summary>
        /// Property holding the name for display in the order summary
        /// </summary>
        public override string Name => ToString();


        /// <summary>
        /// Returns a string with the name of the entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
