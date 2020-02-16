/*
 * BakedBeans.cs
 * Author:Regan Hale
 * Class:BakedBeans
 * Purpose: Represent the Baked Beans side at cowboy cafe
 */
using System;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to represent the Pan de Campo side
    /// </summary>
    public class BakedBeans : Side
    {
        /// <summary>
        /// Property to represent the price of the Baked Beans
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
        /// Property to represent the caloric content of the Baked Beans
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 410;
                    case Size.Medium:
                        return 378;
                    case Size.Small:
                        return 312;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
    }
}
