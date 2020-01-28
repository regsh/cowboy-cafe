/*
 * RustlersRibs.cs
 * Regan Hale
 */
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs
    {
        /// <summary>
        /// The price of the ribs
        /// </summary>
        public double Price
        {
            get
            {
                return 7.50;
            }
        }
        /// <summary>
        /// Calorie content of the ribs
        /// </summary>
        public uint Calories
        {
            get
            {
                return 894;
            }
        }
        /// <summary>
        /// Special instructions for making the entree
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }
    }
}
