/*
 * PanDeCampo.cs
 * Author:Regan Hale
 * Purpose: represent the pan de campo side at cowboy cafe
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to represent the Pan de Campo side
    /// </summary>
    public class PanDeCampo:Side
    {
        /// <summary>
        /// Property to represent the price of the Pan de Campo
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("unknown size");
                }
            }
        }
        /// <summary>
        /// Property to represent the caloric content of the Pan de Campo
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 367;
                    case Size.Medium:
                        return 269;
                    case Size.Small:
                        return 227;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
    }
}
