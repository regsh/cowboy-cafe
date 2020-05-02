/*
 * CornDodgers.cs
 * Author:Regan Hale
 * Class: CornDodgers
 * Purpose: represent the corn dodgers side at the cowboy cafe
 */

using System;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class to represent the Corn Dodgers side at the Cowboy Cafe
    /// </summary>
    public class CornDodgers : Side
    {
        /// <summary>
        /// Property to represent the price of the corn dodgers
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
        /// Property to represent the caloric content of the corn dodgers
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 717;
                    case Size.Medium:
                        return 685;
                    case Size.Small:
                        return 512;
                    default:
                        throw new NotImplementedException("Unknown size");

                }
            }
        }

        /// <summary>
        /// Property holding the name for display in the order summary
        /// </summary>
        public override string Name =>  this.Size.ToString() + " " + this.ToString();

        /// <summary>
        /// Returns the size the name of the side as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Corn Dodgers";
        }
    }
}
