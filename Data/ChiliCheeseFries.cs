/*
 * ChiliCheeseFries.cs
 * Author:Nathan Bean
 * Edited by: Regan Hale
 * Purpose: represent the chili cheese fries side at cowboy cafe
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// Property to represent the price of the Chili Cheese Fries
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 3.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Small:
                        return 1.99;
                    default:
                        throw new NotImplementedException("unknown size");
                }
            }
        }
        /// <summary>
        /// Property to represent the caloric content of the Chili Cheese Fries
        /// </summary>
        public override uint Calories {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 610;
                    case Size.Medium:
                        return 524;
                    case Size.Small:
                        return 433;
                    default:
                        throw new NotImplementedException("Unknown size");
                        
                }
            }
        }
    }
}
