<<<<<<< HEAD
﻿/*
 * RustlersRibs.cs
 * Regan Hale
=======
﻿/*RustlersRibs.cs
 * Author:Regan Hale
 * Purpose: represent the rustlers ribs entree at cowboy cafe
>>>>>>> f61996ff76cfd58387cf23a011f75139de2191c2
 */
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs: Entree
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
    }
}
